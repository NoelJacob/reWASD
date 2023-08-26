﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using reWASDCommon.Infrastructure.Enums;
using reWASDUI.Infrastructure.KeyBindings;
using XBEliteWPF.Infrastructure;
using XBEliteWPF.Infrastructure.reWASDMapping.KeyScanCodes;
using XBEliteWPF.Utils.Extensions;
using XBEliteWPF.Utils.XBUtilModel;

namespace reWASDUI.Utils.Converters
{
	[ValueConversion(typeof(GamepadButton), typeof(Direction))]
	[ValueConversion(typeof(GamepadButtonDescription), typeof(Direction))]
	[ValueConversion(typeof(AssociatedControllerButton), typeof(Direction))]
	public class GamepadButtonToDirectionDrawingConverter : MarkupExtension, IValueConverter
	{
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			GamepadButtonToDirectionDrawingConverter gamepadButtonToDirectionDrawingConverter;
			if ((gamepadButtonToDirectionDrawingConverter = GamepadButtonToDirectionDrawingConverter._converter) == null)
			{
				gamepadButtonToDirectionDrawingConverter = (GamepadButtonToDirectionDrawingConverter._converter = new GamepadButtonToDirectionDrawingConverter());
			}
			return gamepadButtonToDirectionDrawingConverter;
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			GamepadButton? gamepadButton = null;
			KeyScanCodeV2 keyScanCodeV = null;
			if (value is GamepadButton)
			{
				GamepadButton gamepadButton2 = (GamepadButton)value;
				gamepadButton = new GamepadButton?(gamepadButton2);
			}
			GamepadButtonDescription gamepadButtonDescription = value as GamepadButtonDescription;
			if (gamepadButtonDescription != null)
			{
				gamepadButton = new GamepadButton?(gamepadButtonDescription.Button);
			}
			KeyScanCodeV2 keyScanCodeV2 = value as KeyScanCodeV2;
			if (keyScanCodeV2 != null)
			{
				keyScanCodeV = keyScanCodeV2;
			}
			AssociatedControllerButton associatedControllerButton = value as AssociatedControllerButton;
			if (associatedControllerButton != null)
			{
				associatedControllerButton.SetRefButtons(ref gamepadButton, ref keyScanCodeV);
			}
			if (value is GamepadButton)
			{
				GamepadButton gamepadButton3 = (GamepadButton)value;
				gamepadButton = new GamepadButton?(gamepadButton3);
			}
			GamepadButtonDescription gamepadButtonDescription2 = parameter as GamepadButtonDescription;
			if (gamepadButtonDescription2 != null)
			{
				gamepadButton = new GamepadButton?(gamepadButtonDescription2.Button);
			}
			KeyScanCodeV2 keyScanCodeV3 = parameter as KeyScanCodeV2;
			if (keyScanCodeV3 != null)
			{
				keyScanCodeV = keyScanCodeV3;
			}
			AssociatedControllerButton associatedControllerButton2 = parameter as AssociatedControllerButton;
			if (associatedControllerButton2 != null)
			{
				associatedControllerButton2.SetRefButtons(ref gamepadButton, ref keyScanCodeV);
			}
			return XBUtils.GetDrawingForDirection((gamepadButton != null) ? GamepadButtonExtensions.GetDirection(gamepadButton.GetValueOrDefault()) : null, gamepadButton != null && GamepadButtonExtensions.IsAnyPhysicalTrackPad(gamepadButton.GetValueOrDefault()));
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		private static GamepadButtonToDirectionDrawingConverter _converter;
	}
}
