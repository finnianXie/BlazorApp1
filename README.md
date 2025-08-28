# BlazorApp1 - .NET Blazor 应用示例

## 📦 项目概述
这是一个基于ASP.NET Core的Blazor WebAssembly应用模板，演示了现代前端开发的最佳实践：
- ✅ 响应式UI组件化开发（Razor语法）
- 🔧 C#全栈能力实现（前端逻辑+后端交互）
- ⚙️ 模块化架构设计（Pages/Components分离）

## ✨ 核心功能
| 模块 | 说明 |
|------|-----------------------|
| `Counter`       | 交互式计数器演示状态管理 |
| `FetchData`     | API数据获取与绑定展示    |
| `TodoList`      | CRUD操作完整工作流       |
| `WeatherReport` | 第三方API集成案例        |

## 🚀 快速启动
```bash
# 克隆仓库后执行：
dotnet run --project BlazorApp1
```
或通过IDE直接打开解决方案文件 `BlazorApp1.sln`

## 🛠️ 技术栈
- .NET 9.0+
- Blazor WebAssembly Hosted模式
- Razor组件化开发
- RESTful API通信层

## 📚 代码规范
遵循Microsoft官方Blazor编码指南，所有页面组件均位于`Components/Pages`目录下，布局模板在`Components/Layout`中定义。