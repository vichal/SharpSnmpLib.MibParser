using System;
using System.Collections.Generic;
using System.Text;

namespace Lextm.SharpSnmpLib.Mib
{
    public class Resource
    {
        public static String SNMPV2_TC = "#SNMPv2-SMI,";
        public static String SNMPV2_SMI = "# \n" +
                                        ".1.3,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,org,iso \n" +
                                        ".1.3.6,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,dod,org \n" +
                                        ".1.3.6.1,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,internet,dod \n" +
                                        ".1.3.6.1.1,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,directory,internet \n" +
                                        ".1.3.6.1.2,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,mgmt,internet \n" +
                                        ".1.3.6.1.2.1,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,mib-2,mgmt \n" +
                                        ".1.3.6.1.2.1.10,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,transmission,mib-2 \n" +
                                        ".1.3.6.1.3,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,experimental,internet \n" +
                                        ".1.3.6.1.4,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,private,internet \n" +
                                        ".1.3.6.1.4.1,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,enterprises,private \n" +
                                        ".1.3.6.1.5,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,security,internet \n" +
                                        ".1.3.6.1.6,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpV2,internet \n" +
                                        ".1.3.6.1.6.1,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpDomains,snmpV2 \n" +
                                        ".1.3.6.1.6.2,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpProxys,snmpV2 \n" +
                                        ".1.3.6.1.6.3,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpModules,snmpV2 \n" +
                                        ".0.0,Lextm.SharpSnmpLib.Mib.ObjectIdentityMacro,zeroDotZero,ccitt";
        public static String SNMPV2_CONF = "#SNMPv2-SMI,";

        public static String SNMPV2_TM = "#SNMPv2-SMI,SNMPv2-TC, \n" +
                                        ".1.3.6.1.6.3.19, Lextm.SharpSnmpLib.Mib.ModuleIdentityMacro,snmpv2tm,snmpModules \n" +
                                        ".1.3.6.1.6.1.1,Lextm.SharpSnmpLib.Mib.ObjectIdentityMacro,snmpUDPDomain,snmpDomains \n" +
                                        ".1.3.6.1.6.1.2,Lextm.SharpSnmpLib.Mib.ObjectIdentityMacro,snmpCLNSDomain,snmpDomains \n" +
                                        ".1.3.6.1.6.1.3,Lextm.SharpSnmpLib.Mib.ObjectIdentityMacro,snmpCONSDomain,snmpDomains \n" +
                                        ".1.3.6.1.6.1.4,Lextm.SharpSnmpLib.Mib.ObjectIdentityMacro,snmpDDPDomain,snmpDomains \n" +
                                        ".1.3.6.1.6.1.5,Lextm.SharpSnmpLib.Mib.ObjectIdentityMacro,snmpIPXDomain,snmpDomains \n" +
                                        ".1.3.6.1.6.2.1,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,rfc1157Proxy,snmpProxys \n" +
                                        ".1.3.6.1.6.2.1.1,Lextm.SharpSnmpLib.Mib.ObjectIdentityMacro,rfc1157Domain,rfc1157Proxy";
        public static String SNMPV2_MIB = "#SNMPv2-SMI,SNMPv2-TC,SNMPv2-CONF, \n" +
                                        ".1.3.6.1.6.3.1,Lextm.SharpSnmpLib.Mib.ModuleIdentityMacro,snmpMIB,snmpModules \n" +
                                        ".1.3.6.1.6.3.1.1,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpMIBObjects,snmpMIB \n" +
                                        ".1.3.6.1.2.1.1,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,system,mib-2 \n" +
                                        ".1.3.6.1.2.1.1.1,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysDescr,system \n" +
                                        ".1.3.6.1.2.1.1.2,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysObjectID,system \n" +
                                        ".1.3.6.1.2.1.1.3,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysUpTime,system \n" +
                                        ".1.3.6.1.2.1.1.4,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysContact,system \n" +
                                        ".1.3.6.1.2.1.1.5,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysName,system \n" +
                                        ".1.3.6.1.2.1.1.6,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysLocation,system \n" +
                                        ".1.3.6.1.2.1.1.7,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysServices,system \n" +
                                        ".1.3.6.1.2.1.1.8,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysORLastChange,system \n" +
                                        ".1.3.6.1.2.1.1.9,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysORTable,system \n" +
                                        ".1.3.6.1.2.1.1.9.1,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysOREntry,sysORTable \n" +
                                        ".1.3.6.1.2.1.1.9.1.1,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysORIndex,sysOREntry \n" +
                                        ".1.3.6.1.2.1.1.9.1.2,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysORID,sysOREntry \n" +
                                        ".1.3.6.1.2.1.1.9.1.3,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysORDescr,sysOREntry \n" +
                                        ".1.3.6.1.2.1.1.9.1.4,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,sysORUpTime,sysOREntry \n" +
                                        ".1.3.6.1.2.1.11,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmp,mib-2 \n" +
                                        ".1.3.6.1.2.1.11.1,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInPkts,snmp \n" +
                                        ".1.3.6.1.2.1.11.3,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInBadVersions,snmp \n" +
                                        ".1.3.6.1.2.1.11.4,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInBadCommunityNames,snmp \n" +
                                        ".1.3.6.1.2.1.11.5,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInBadCommunityUses,snmp \n" +
                                        ".1.3.6.1.2.1.11.6,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInASNParseErrs,snmp \n" +
                                        ".1.3.6.1.2.1.11.30,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpEnableAuthenTraps,snmp \n" +
                                        ".1.3.6.1.2.1.11.31,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpSilentDrops,snmp \n" +
                                        ".1.3.6.1.2.1.11.32,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpProxyDrops,snmp \n" +
                                        ".1.3.6.1.6.3.1.1.4,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpTrap,snmpMIBObjects \n" +
                                        ".1.3.6.1.6.3.1.1.4.1,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpTrapOID,snmpTrap \n" +
                                        ".1.3.6.1.6.3.1.1.4.3,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpTrapEnterprise,snmpTrap \n" +
                                        ".1.3.6.1.6.3.1.1.5,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpTraps,snmpMIBObjects \n" +
                                        ".1.3.6.1.6.3.1.1.5.1,Lextm.SharpSnmpLib.Mib.NotificationTypeMacro,coldStart,snmpTraps \n" +
                                        ".1.3.6.1.6.3.1.1.5.2,Lextm.SharpSnmpLib.Mib.NotificationTypeMacro,warmStart,snmpTraps \n" +
                                        ".1.3.6.1.6.3.1.1.5.5,Lextm.SharpSnmpLib.Mib.NotificationTypeMacro,authenticationFailure,snmpTraps \n" +
                                        ".1.3.6.1.6.3.1.1.6,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpSet,snmpMIBObjects \n" +
                                        ".1.3.6.1.6.3.1.1.6.1,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpSetSerialNo,snmpSet \n" +
                                        ".1.3.6.1.6.3.1.2,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpMIBConformance,snmpMIB \n" +
                                        ".1.3.6.1.6.3.1.2.1,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpMIBCompliances,snmpMIBConformance \n" +
                                        ".1.3.6.1.6.3.1.2.2,Lextm.SharpSnmpLib.Mib.ObjectIdentifierType,snmpMIBGroups,snmpMIBConformance \n" +
                                        ".1.3.6.1.6.3.1.2.1.2,Lextm.SharpSnmpLib.Mib.ModuleComplianceMacro,snmpBasicCompliance,snmpMIBCompliances \n" +
                                        ".1.3.6.1.6.3.1.2.1.3,Lextm.SharpSnmpLib.Mib.ModuleComplianceMacro,snmpBasicComplianceRev2,snmpMIBCompliances \n" +
                                        ".1.3.6.1.6.3.1.2.2.8,Lextm.SharpSnmpLib.Mib.ObjectGroupMacro,snmpGroup,snmpMIBGroups \n" +
                                        ".1.3.6.1.6.3.1.2.2.9,Lextm.SharpSnmpLib.Mib.ObjectGroupMacro,snmpCommunityGroup,snmpMIBGroups \n" +
                                        ".1.3.6.1.6.3.1.2.2.5,Lextm.SharpSnmpLib.Mib.ObjectGroupMacro,snmpSetGroup,snmpMIBGroups \n" +
                                        ".1.3.6.1.6.3.1.2.2.6,Lextm.SharpSnmpLib.Mib.ObjectGroupMacro,systemGroup,snmpMIBGroups \n" +
                                        ".1.3.6.1.6.3.1.2.2.7,Lextm.SharpSnmpLib.Mib.NotificationGroupMacro,snmpBasicNotificationsGroup,snmpMIBGroups \n" +
                                        ".1.3.6.1.6.3.1.2.2.11,Lextm.SharpSnmpLib.Mib.NotificationGroupMacro,snmpWarmStartNotificationGroup,snmpMIBGroups \n" +
                                        ".1.3.6.1.6.3.1.2.2.12,Lextm.SharpSnmpLib.Mib.ObjectGroupMacro,snmpNotificationGroup,snmpMIBGroups \n" +
                                        ".1.3.6.1.2.1.11.2,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutPkts,snmp \n" +
                                        ".1.3.6.1.2.1.11.8,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInTooBigs,snmp \n" +
                                        ".1.3.6.1.2.1.11.9,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInNoSuchNames,snmp \n" +
                                        ".1.3.6.1.2.1.11.10,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInBadValues,snmp \n" +
                                        ".1.3.6.1.2.1.11.11,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInReadOnlys,snmp \n" +
                                        ".1.3.6.1.2.1.11.12,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInGenErrs,snmp \n" +
                                        ".1.3.6.1.2.1.11.13,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInTotalReqVars,snmp \n" +
                                        ".1.3.6.1.2.1.11.14,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInTotalSetVars,snmp \n" +
                                        ".1.3.6.1.2.1.11.15,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInGetRequests,snmp \n" +
                                        ".1.3.6.1.2.1.11.16,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInGetNexts,snmp \n" +
                                        ".1.3.6.1.2.1.11.17,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInSetRequests,snmp \n" +
                                        ".1.3.6.1.2.1.11.18,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInGetResponses,snmp \n" +
                                        ".1.3.6.1.2.1.11.19,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpInTraps,snmp \n" +
                                        ".1.3.6.1.2.1.11.20,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutTooBigs,snmp \n" +
                                        ".1.3.6.1.2.1.11.21,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutNoSuchNames,snmp \n" +
                                        ".1.3.6.1.2.1.11.22,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutBadValues,snmp \n" +
                                        ".1.3.6.1.2.1.11.24,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutGenErrs,snmp \n" +
                                        ".1.3.6.1.2.1.11.25,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutGetRequests,snmp \n" +
                                        ".1.3.6.1.2.1.11.26,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutGetNexts,snmp \n" +
                                        ".1.3.6.1.2.1.11.27,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutSetRequests,snmp \n" +
                                        ".1.3.6.1.2.1.11.28,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutGetResponses,snmp \n" +
                                        ".1.3.6.1.2.1.11.29,Lextm.SharpSnmpLib.Mib.ObjectTypeMacro,snmpOutTraps,snmp \n" +
                                        ".1.3.6.1.6.3.1.2.2.10,Lextm.SharpSnmpLib.Mib.ObjectGroupMacro,snmpObsoleteGroup,snmpMIBGroups";

    }
}
