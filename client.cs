exec("./TapperGui.gui");
if(!$TapperBinds) {
    $remapDivision[$remapCount] = "Tapper";
    $remapName[$remapCount] = "Open TapperGUI";
    $remapCmd[$remapCount] = "openTapperGui";
    $remapCount++;
    $TapperBinds = true;
}

function tapperApplyScale()
{
	%x = TapperScaleX.getValue();
	%y = TapperScaleY.getValue();
	%z = TapperScaleZ.getValue();
	serverConnection.getControlObject().setScale(%x SPC %y SPC %z);
}

function openTapperGui()
{
	if(TapperGui.isAwake())
	{
		canvas.popDialog(TapperGui);
	}
	else
	{
		canvas.pushDialog(TapperGui);
	}
}

function tapperIncreaseScaleX()
{
	TapperScaleX.setValue(TapperScaleX.getValue() + 0.1);
	tapperApplyScale();
}

function tapperIncreaseScaleY()
{
	TapperScaleY.setValue(TapperScaleY.getValue() + 0.1);
	tapperApplyScale();
}

function tapperIncreaseScaleZ()
{
	TapperScaleZ.setValue(TapperScaleZ.getValue() + 0.1);
	tapperApplyScale();
}

function tapperDecreaseScaleX()
{
	TapperScaleX.setValue(TapperScaleX.getValue() - 0.1);
	tapperApplyScale();
}

function tapperDecreaseScaleY()
{
	TapperScaleY.setValue(TapperScaleY.getValue() - 0.1);
	tapperApplyScale();
}

function tapperDecreaseScaleZ()
{
	TapperScaleZ.setValue(TapperScaleZ.getValue() - 0.1);
	tapperApplyScale();
}

function tapperRefresh()
{
	%scale = serverconnection.getcontrolobject().getScale();
	%x = getWord(%scale, 0);
	%y = getWord(%scale, 1);
	%z = getWord(%scale, 2);
	TapperScaleX.setValue(%x);
	TapperScaleY.setValue(%y);
	TapperScaleZ.setValue(%z);
}

function tapperChaseCamOff()
{
	serverConnection.chaseCam(-1);
}

function tapperSetChaseCam()
{
	serverConnection.chaseCam(TapperChaseCamSize.getValue());
}

function tapperGetTransform()
{
	TapperTransformIndicator.setValue("<font:impact:18><color:00ff00>" @ serverConnection.getControlObject().getTransform());
}

function tapperServerConnectionSend()
{
	%ev = TapperServerConnectionCode.getValue();
	eval("ServerConnection." @ %ev @ ";");
}

function tapperControlObjectSend()
{
	%ev = TapperServerConnectionPlayerCode.getValue();
	eval("ServerConnection.getControlObject()." @ %ev @ ";");
}

