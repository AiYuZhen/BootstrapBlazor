﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License
// See the LICENSE file in the project root for more information.
// Maintainer: Argo Zhang(argo@live.ca) Website: https://www.blazor.zone

using Microsoft.AspNetCore.Components.Forms;

namespace BootstrapBlazor.Components;

/// <summary>
/// Table 编辑配置接口
/// </summary>
public interface ITableEditDialogOption<TModel>
{
    /// <summary>
    /// 获得/设置 组件是否采用 Tracking 模式对编辑项进行直接更新 默认 false
    /// </summary>
    bool IsTracking { get; set; }

    /// <summary>
    /// 获得/设置 是否显示标签 默认为 true 显示标签
    /// </summary>
    bool ShowLabel { get; set; }

    /// <summary>
    /// 获得/设置 实体类编辑模式 Add 还是 Update
    /// </summary>
    ItemChangedType ItemChangedType { get; set; }

    /// <summary>
    /// 获得/设置 每行显示组件数量 默认为 null
    /// </summary>
    int? ItemsPerRow { get; set; }

    /// <summary>
    /// 获得/设置 设置行内组件布局格式 默认 Row 布局
    /// </summary>
    RowType RowType { get; set; }

    /// <summary>
    /// 获得/设置 设置 <see cref="RowType" /> Inline 模式下标签对齐方式 默认 None 等效于 Left 左对齐
    /// </summary>
    Alignment LabelAlign { get; set; }

    /// <summary>
    /// 获得/设置 查询时是否显示正在加载中动画 默认为 false
    /// </summary>
    bool ShowLoading { get; set; }

    /// <summary>
    /// 获得/设置 未分组编辑项布局位置 默认 false 在尾部
    /// </summary>
    bool ShowUnsetGroupItemsOnTop { get; set; }

    /// <summary>
    /// 获得/设置 编辑框模型
    /// </summary>
    TModel? Model { get; set; }

    /// <summary>
    /// 获得/设置 是否禁用表单内回车自动提交功能 默认 null 未设置
    /// </summary>
    bool? DisableAutoSubmitFormByEnter { get; set; }

    /// <summary>
    /// 获得/设置 保存按钮文本
    /// </summary>
    string? SaveButtonText { get; set; }

    /// <summary>
    /// 获得/设置 保存按钮图标 默认 null 使用当前主题图标
    /// </summary>
    string? SaveButtonIcon { get; set; }

    /// <summary>
    /// 获得/设置 关闭按钮文本
    /// </summary>
    string? CloseButtonText { get; set; }

    /// <summary>
    /// 获得/设置 关闭按钮图标 默认 null 使用当前主题图标
    /// </summary>
    string? CloseButtonIcon { get; set; }

    /// <summary>
    /// 获得 编辑项集合
    /// </summary>
    IEnumerable<IEditorItem>? Items { get; set; }

    /// <summary>
    /// 获得/设置 保存回调委托
    /// </summary>
    Func<EditContext, Task<bool>>? OnEditAsync { get; set; }

    /// <summary>
    /// 获得/设置 关闭弹窗回调方法
    /// </summary>
    Func<Task>? OnCloseAsync { get; set; }

    /// <summary>
    /// 获得/设置 EditDialog Body 模板
    /// </summary>
    RenderFragment<TModel>? DialogBodyTemplate { get; set; }

    /// <summary>
    /// 获得/设置 EditDialog Footer 模板
    /// </summary>
    RenderFragment<TModel>? DialogFooterTemplate { get; set; }
}
