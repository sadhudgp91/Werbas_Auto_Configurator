using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace SchemaValidator
{
    public partial class ValidateSchema : Form
    {
        bool error_flag = false;

        public ValidateSchema()
        {
            InitializeComponent();
        }

        private void btnBrowseXML_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog dialog = new OpenFileDialog();
                dialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.DefaultExt = "xml";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtXMLFileName.Text = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseXSD_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Schema Files (*.xsd)|*.xsd|All Files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.DefaultExt = "xsd";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtXSDFileName.Text = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtXMLFileName.Clear();
            txtXSDFileName.Clear();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                XmlReader reader = XmlReader.Create(txtXMLFileName.Text);
                XmlValidatingReader vreader = new XmlValidatingReader(reader);
                XmlReader schemareader = XmlReader.Create(txtXSDFileName.Text);
                XmlSchemaCollection schemacollection = new XmlSchemaCollection();
                schemacollection.Add("", txtXSDFileName.Text);
                vreader.Schemas.Add(schemacollection);
                vreader.ValidationEventHandler += new ValidationEventHandler(vreader_ValidationEventHandler);
                while (vreader.Read()) { }
                if (!error_flag)
                {
                    MessageBox.Show("No Error", "Valid XML file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void vreader_ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            error_flag = true;
        }
    }
}