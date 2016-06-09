using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputManSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // 特定の文字数区切りのプロダクトキー(数字で3,4,4文字区切り)を入力することを想定
            MaskPatternField field1 = new MaskPatternField("\\D", 3, 3);
            MaskPatternField field2 = new MaskPatternField("\\D", 4, 4);
            MaskPatternField field3 = new MaskPatternField("\\D", 4, 4);

            // 3つめのフィールドはパスワードとしてマスクする
            //field3.PasswordChar = '*';

            // 1つめのフィールドは青文字
            field1.ForeColor = Color.Blue;

            MaskLiteralField line = new MaskLiteralField("-");
            MaskLiteralField line2 = new MaskLiteralField("-");

            gcMask1.Fields.Add(field1);
            gcMask1.Fields.Add(line);
            gcMask1.Fields.Add(field2);
            gcMask1.Fields.Add(line2);
            gcMask1.Fields.Add(field3);


            // ショートカットのコレクションを作成
            ShortcutCollection sc = new ShortcutCollection();

            // Ctr+Shift+Aでよく使う文字を入力
            sc.Add(Keys.A | Keys.Shift | Keys.Control, new MethodInvoker(() => { this.textBox1.Text = "いつもの定型文"; }));

            // ショートカット登録
            // この場合textBox1がアクティブな場合に有効
            // Windows Forms標準のTextBoxにも適用可能
            gcShortcut1.SetShortcuts(this.textBox1, sc);
        }
    }
}
