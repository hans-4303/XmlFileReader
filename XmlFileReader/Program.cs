using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// <para>해당 애플리케이션의 주 진입점.</para>
/// <para>1. [STAThread]</para>
/// <para>
///     STA 모델을 나타내는 속성, UI 컴포넌트 간 상호작용을 보장하기 위해 사용됨.
///     STA 모델에서는 UI 스레드 외 다른 스레드에서 UI 컴포넌트에 대한 접근이 허용되지 않음.
///     Windows Forms 애플리케이션에서는 주로 STA 모델이 사용
///     진입점에 명시해서 해당 애플리케이션에 STA 모델을 따르도록 지정함.
/// </para>
/// <para>2. Application.EnableVisualStyles();</para>
/// <para>
///     Windows Forms 애플리케이션이 시각적 스타일을 활성화하도록 지정하는 메서드
///     시각적 스타일을 활성화하면 Windows 테마를 사용하여 UI가 렌더링되며, 더욱 풍부하고 모던한 사용자 경험을 제공
/// </para>
/// <para>3. Application.SetCompatibleTextRenderingDefault(true || false)</para>
/// <para>
///     이 애플리케이션이 GDI+를 사용하여 텍스트를 렌더링할지 결정할 수 있음
///     false로 설정하면 GDI+가 아닌 Windows GDI를 사용하여 텍스트 렌더링
///     이 설정은 이전버전 .NET Framework 호환성을 제공하며 대부분 경우 false로 설정하는 것이 권장됨.
/// </para>
/// <para>4. Windows GDI VS GDI+ </para>
/// <para>
///     Windows GDI: 윈도우 초기 그래픽 시스템(레거시), C 및 C++과 같은 언어에서 사용되는 비관리 코드
/// </para>
/// <para>
///     GDI+: Windows GDI가 확장, 고급 그래픽 효과, Win 98 이상,
///     .NET 환경에서 C#/VB.NET 같은 언어에서 사용되는 관리 코드 개발 가능,
///     다양한 이미지 포맷(JPEG, PNG, GIF과 같은 현대적 이미지 포맷) 지원
/// </para>
/// </summary>
namespace XmlFileReader
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
