using IndyPOS.CashFlow.Application.Common.Enums;

namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IRawInputDeviceService
{
	void Start(IntPtr handle);

	void Stop();

	void SetMode(RawInputDeviceMode mode);

	void LoadConfiguration();
}