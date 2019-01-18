/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class SaveApRadioSsidConfigRequest : RpcAcsRequest<SaveApRadioSsidConfigResponse>
    {
        public SaveApRadioSsidConfigRequest()
            : base("cloudwf", "2017-03-28", "SaveApRadioSsidConfig")
        {
        }

		private string nasid;

		private int? authPort;

		private int? hidden;

		private int? dynamicVlan;

		private string authServer;

		private string secondaryAcctServer;

		private string ssid;

		private int? cir;

		private string mac;

		private string secondaryAcctSecret;

		private string accessKeyId;

		private int? ieee80211w;

		private int? network;

		private int? isolate;

		private long? apAssetId;

		private string encKey;

		private int? multicastForward;

		private string encryption;

		private int? wmm;

		private int? authCache;

		private int? disabled;

		private long? id;

		private int? radioIndex;

		private int? ignoreWeakProbe;

		private int? maxassoc;

		private string acctServer;

		private string secondaryAuthServer;

		private string daeClient;

		private string daeSecret;

		private int? disassocLowAck;

		private int? secondaryAuthPort;

		private string acctSecret;

		private int? disassocWeakRssi;

		private int? secondaryAcctPort;

		private int? daePort;

		private int? ssidLb;

		private int? acctPort;

		private int? maxInactivity;

		private int? vlanDhcp;

		private int? instantlyEffective;

		private int? shortPreamble;

		private string authSecret;

		private string secondaryAuthSecret;

		private string ownip;

		public string Nasid
		{
			get
			{
				return nasid;
			}
			set	
			{
				nasid = value;
				DictionaryUtil.Add(QueryParameters, "Nasid", value);
			}
		}

		public int? AuthPort
		{
			get
			{
				return authPort;
			}
			set	
			{
				authPort = value;
				DictionaryUtil.Add(QueryParameters, "AuthPort", value.ToString());
			}
		}

		public int? Hidden
		{
			get
			{
				return hidden;
			}
			set	
			{
				hidden = value;
				DictionaryUtil.Add(QueryParameters, "Hidden", value.ToString());
			}
		}

		public int? DynamicVlan
		{
			get
			{
				return dynamicVlan;
			}
			set	
			{
				dynamicVlan = value;
				DictionaryUtil.Add(QueryParameters, "DynamicVlan", value.ToString());
			}
		}

		public string AuthServer
		{
			get
			{
				return authServer;
			}
			set	
			{
				authServer = value;
				DictionaryUtil.Add(QueryParameters, "AuthServer", value);
			}
		}

		public string SecondaryAcctServer
		{
			get
			{
				return secondaryAcctServer;
			}
			set	
			{
				secondaryAcctServer = value;
				DictionaryUtil.Add(QueryParameters, "SecondaryAcctServer", value);
			}
		}

		public string Ssid
		{
			get
			{
				return ssid;
			}
			set	
			{
				ssid = value;
				DictionaryUtil.Add(QueryParameters, "Ssid", value);
			}
		}

		public int? Cir
		{
			get
			{
				return cir;
			}
			set	
			{
				cir = value;
				DictionaryUtil.Add(QueryParameters, "Cir", value.ToString());
			}
		}

		public string Mac
		{
			get
			{
				return mac;
			}
			set	
			{
				mac = value;
				DictionaryUtil.Add(QueryParameters, "Mac", value);
			}
		}

		public string SecondaryAcctSecret
		{
			get
			{
				return secondaryAcctSecret;
			}
			set	
			{
				secondaryAcctSecret = value;
				DictionaryUtil.Add(QueryParameters, "SecondaryAcctSecret", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public int? Ieee80211w
		{
			get
			{
				return ieee80211w;
			}
			set	
			{
				ieee80211w = value;
				DictionaryUtil.Add(QueryParameters, "Ieee80211w", value.ToString());
			}
		}

		public int? Network
		{
			get
			{
				return network;
			}
			set	
			{
				network = value;
				DictionaryUtil.Add(QueryParameters, "Network", value.ToString());
			}
		}

		public int? Isolate
		{
			get
			{
				return isolate;
			}
			set	
			{
				isolate = value;
				DictionaryUtil.Add(QueryParameters, "Isolate", value.ToString());
			}
		}

		public long? ApAssetId
		{
			get
			{
				return apAssetId;
			}
			set	
			{
				apAssetId = value;
				DictionaryUtil.Add(QueryParameters, "ApAssetId", value.ToString());
			}
		}

		public string EncKey
		{
			get
			{
				return encKey;
			}
			set	
			{
				encKey = value;
				DictionaryUtil.Add(QueryParameters, "EncKey", value);
			}
		}

		public int? MulticastForward
		{
			get
			{
				return multicastForward;
			}
			set	
			{
				multicastForward = value;
				DictionaryUtil.Add(QueryParameters, "MulticastForward", value.ToString());
			}
		}

		public string Encryption
		{
			get
			{
				return encryption;
			}
			set	
			{
				encryption = value;
				DictionaryUtil.Add(QueryParameters, "Encryption", value);
			}
		}

		public int? Wmm
		{
			get
			{
				return wmm;
			}
			set	
			{
				wmm = value;
				DictionaryUtil.Add(QueryParameters, "Wmm", value.ToString());
			}
		}

		public int? AuthCache
		{
			get
			{
				return authCache;
			}
			set	
			{
				authCache = value;
				DictionaryUtil.Add(QueryParameters, "AuthCache", value.ToString());
			}
		}

		public int? Disabled
		{
			get
			{
				return disabled;
			}
			set	
			{
				disabled = value;
				DictionaryUtil.Add(QueryParameters, "Disabled", value.ToString());
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public int? RadioIndex
		{
			get
			{
				return radioIndex;
			}
			set	
			{
				radioIndex = value;
				DictionaryUtil.Add(QueryParameters, "RadioIndex", value.ToString());
			}
		}

		public int? IgnoreWeakProbe
		{
			get
			{
				return ignoreWeakProbe;
			}
			set	
			{
				ignoreWeakProbe = value;
				DictionaryUtil.Add(QueryParameters, "IgnoreWeakProbe", value.ToString());
			}
		}

		public int? Maxassoc
		{
			get
			{
				return maxassoc;
			}
			set	
			{
				maxassoc = value;
				DictionaryUtil.Add(QueryParameters, "Maxassoc", value.ToString());
			}
		}

		public string AcctServer
		{
			get
			{
				return acctServer;
			}
			set	
			{
				acctServer = value;
				DictionaryUtil.Add(QueryParameters, "AcctServer", value);
			}
		}

		public string SecondaryAuthServer
		{
			get
			{
				return secondaryAuthServer;
			}
			set	
			{
				secondaryAuthServer = value;
				DictionaryUtil.Add(QueryParameters, "SecondaryAuthServer", value);
			}
		}

		public string DaeClient
		{
			get
			{
				return daeClient;
			}
			set	
			{
				daeClient = value;
				DictionaryUtil.Add(QueryParameters, "DaeClient", value);
			}
		}

		public string DaeSecret
		{
			get
			{
				return daeSecret;
			}
			set	
			{
				daeSecret = value;
				DictionaryUtil.Add(QueryParameters, "DaeSecret", value);
			}
		}

		public int? DisassocLowAck
		{
			get
			{
				return disassocLowAck;
			}
			set	
			{
				disassocLowAck = value;
				DictionaryUtil.Add(QueryParameters, "DisassocLowAck", value.ToString());
			}
		}

		public int? SecondaryAuthPort
		{
			get
			{
				return secondaryAuthPort;
			}
			set	
			{
				secondaryAuthPort = value;
				DictionaryUtil.Add(QueryParameters, "SecondaryAuthPort", value.ToString());
			}
		}

		public string AcctSecret
		{
			get
			{
				return acctSecret;
			}
			set	
			{
				acctSecret = value;
				DictionaryUtil.Add(QueryParameters, "AcctSecret", value);
			}
		}

		public int? DisassocWeakRssi
		{
			get
			{
				return disassocWeakRssi;
			}
			set	
			{
				disassocWeakRssi = value;
				DictionaryUtil.Add(QueryParameters, "DisassocWeakRssi", value.ToString());
			}
		}

		public int? SecondaryAcctPort
		{
			get
			{
				return secondaryAcctPort;
			}
			set	
			{
				secondaryAcctPort = value;
				DictionaryUtil.Add(QueryParameters, "SecondaryAcctPort", value.ToString());
			}
		}

		public int? DaePort
		{
			get
			{
				return daePort;
			}
			set	
			{
				daePort = value;
				DictionaryUtil.Add(QueryParameters, "DaePort", value.ToString());
			}
		}

		public int? SsidLb
		{
			get
			{
				return ssidLb;
			}
			set	
			{
				ssidLb = value;
				DictionaryUtil.Add(QueryParameters, "SsidLb", value.ToString());
			}
		}

		public int? AcctPort
		{
			get
			{
				return acctPort;
			}
			set	
			{
				acctPort = value;
				DictionaryUtil.Add(QueryParameters, "AcctPort", value.ToString());
			}
		}

		public int? MaxInactivity
		{
			get
			{
				return maxInactivity;
			}
			set	
			{
				maxInactivity = value;
				DictionaryUtil.Add(QueryParameters, "MaxInactivity", value.ToString());
			}
		}

		public int? VlanDhcp
		{
			get
			{
				return vlanDhcp;
			}
			set	
			{
				vlanDhcp = value;
				DictionaryUtil.Add(QueryParameters, "VlanDhcp", value.ToString());
			}
		}

		public int? InstantlyEffective
		{
			get
			{
				return instantlyEffective;
			}
			set	
			{
				instantlyEffective = value;
				DictionaryUtil.Add(QueryParameters, "InstantlyEffective", value.ToString());
			}
		}

		public int? ShortPreamble
		{
			get
			{
				return shortPreamble;
			}
			set	
			{
				shortPreamble = value;
				DictionaryUtil.Add(QueryParameters, "ShortPreamble", value.ToString());
			}
		}

		public string AuthSecret
		{
			get
			{
				return authSecret;
			}
			set	
			{
				authSecret = value;
				DictionaryUtil.Add(QueryParameters, "AuthSecret", value);
			}
		}

		public string SecondaryAuthSecret
		{
			get
			{
				return secondaryAuthSecret;
			}
			set	
			{
				secondaryAuthSecret = value;
				DictionaryUtil.Add(QueryParameters, "SecondaryAuthSecret", value);
			}
		}

		public string Ownip
		{
			get
			{
				return ownip;
			}
			set	
			{
				ownip = value;
				DictionaryUtil.Add(QueryParameters, "Ownip", value);
			}
		}

        public override SaveApRadioSsidConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveApRadioSsidConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}