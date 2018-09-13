using System;
using Smobiler.Core.Controls;
using SMOWMS.UI.MasterData;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ������Զ���ؼ��������䣬true���ӣ�false������
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsExLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������
        
        /// <summary>
        /// �����������ʲ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void touchPanel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssetsDetail detail = new frmAssetsDetail {AssId = lblID.BindDataValue.ToString()};
                Form.Show(detail, (MobileForm sender1, object args) =>
                    {
                        if (detail.ShowResult == ShowResult.Yes)
                        {
                            ((frmAssets)Form).Bind();
                        }

                    }
                );
            }
            catch (Exception ex)
            {
                Parent.Form.Toast(ex.Message);
            }
        }

        /// <summary>
        /// CheckBox�ı�ѡ��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((frmAssets) Form).SelectAssId = checkBox1.Checked ? lblID.Text : "";
                ((frmAssets)Form).Bind();
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}