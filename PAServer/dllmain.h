// dllmain.h : Declaration of module class.

class CPAServerModule : public ATL::CAtlDllModuleT< CPAServerModule >
{
public :
	DECLARE_LIBID(LIBID_PAServerLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_PASERVER, "{c2ceb8c1-9f99-4e63-9e3f-ea802428faa0}")
};

extern class CPAServerModule _AtlModule;
