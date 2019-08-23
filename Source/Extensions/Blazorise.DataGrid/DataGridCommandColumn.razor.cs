﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise.DataGrid
{
    public abstract class BaseDataGridCommandColumn<TItem> : BaseDataGridColumn<TItem>
    {
        #region Members

        #endregion

        #region Methods

        #endregion

        #region Properties

        public override DataGridColumnType ColumnType => DataGridColumnType.Command;

        [Parameter] public RenderFragment<CommandContext> NewCommandTemplate { get; set; }

        [Parameter] public RenderFragment<CommandContext<TItem>> EditCommandTemplate { get; set; }

        [Parameter] public RenderFragment<CommandContext<TItem>> SaveCommandTemplate { get; set; }

        [Parameter] public RenderFragment<CommandContext<TItem>> CancelCommandTemplate { get; set; }

        [Parameter] public RenderFragment<CommandContext<TItem>> DeleteCommandTemplate { get; set; }

        [Parameter] public RenderFragment<CommandContext> ClearFilterCommandTemplate { get; set; }

        #endregion
    }
}
