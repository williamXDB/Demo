using System;
using System.Windows;

namespace WPFBindingDemo
{
    /// <summary>
    /// BindingToCollection.xaml 的交互逻辑
    /// </summary>
    public partial class BindingToCollection : Window
    {
        private Student m_student;
        public BindingToCollection()
        {
            InitializeComponent();
            m_student = new Student() { ID = 1, StudentName = "LearningHard", Score = 60,BirthDate = DateTime.Now };
            // 设置Window对象的DataContext属性
            this.DataContext = m_student;
        }

        private void ChangeScore_Click(object sender, RoutedEventArgs e)
        {
            m_student.Score = 90;
        }

        private void changeName_Click_1(object sender, RoutedEventArgs e)
        {
            m_student.StudentName = "Learning";
        }

        private void changeDate_Click(object sender, RoutedEventArgs e)
        {
            m_student.BirthDate = new DateTime(2019, 10, 25);
        }

        /*
         * 本例总结：
           关于事件绑定，
           此例中，已完全摆脱了以前那种编程方式，通过仅改变数据源，而无需去关心界面本身，
           只需改变数据源中的字段的改变，数据源本身就能自动更动更改显示在界面中
           而数据源与界面之前仅只需要完成绑定的动作即可
           ，
           这里完全是一个系统元素的数据源，Student类，本身并没有系统自带的通知功能，
           也就是如果Student类的成员一旦发生变化，并不会去通知绑定对应的UI进行更新
           因而Student自定义类需要继承自INotifyPropertyChanged 类，
           一旦Student的成员值发生了变化，就会去notify通知组件进行改变（只要发出通知就好）
           其余交给C#的底层去处理
           本实例中将Student自定义类的几个成员变量绑定到Textblock的Text
           同时this.DataContext指定的数据源，通过在最底层进行指定的方式，让组件去寻找数据源
         */


    }
}
