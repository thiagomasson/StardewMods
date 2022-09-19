using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leclair.Stardew.BetterCrafting.Models;
using Leclair.Stardew.Common.Crafting;
using Leclair.Stardew.Common.UI.FlowNode;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using StardewValley;
using StardewValley.Menus;

using SObject = StardewValley.Object;

namespace Leclair.Stardew.BetterCrafting.DynamicTypes;

public class SprinklerTypeHandler : IDynamicTypeHandler {
	public string DisplayName => I18n.Filter_Sprinkler();

	public string Description => I18n.Filter_Sprinkler_About();

	public Texture2D Texture => Game1.objectSpriteSheet;

	public Rectangle Source => Game1.getSourceRectForStandardTileSheet(Game1.objectSpriteSheet, 621, 16, 16);

	public bool AllowMultiple => false;

	public bool HasEditor => false;

	public bool DoesRecipeMatch(IRecipe recipe, Lazy<Item?> item, object? state) {
		return item.Value is SObject sobj && sobj.IsSprinkler();
	}

	public IClickableMenu? GetEditor(IDynamicType type) {
		return null;
	}

	public IFlowNode[]? GetExtraInfo(object? state) {
		return null;
	}

	public object? ParseState(IDynamicType type) {
		return null;
	}
}
