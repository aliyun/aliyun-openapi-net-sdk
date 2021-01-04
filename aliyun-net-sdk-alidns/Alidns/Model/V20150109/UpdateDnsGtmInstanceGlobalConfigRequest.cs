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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class UpdateDnsGtmInstanceGlobalConfigRequest : RpcAcsRequest<UpdateDnsGtmInstanceGlobalConfigResponse>
    {
        public UpdateDnsGtmInstanceGlobalConfigRequest()
            : base("Alidns", "2015-01-09", "UpdateDnsGtmInstanceGlobalConfig", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string alertGroup;

		private string cnameType;

		private string lang;

		private List<AlertConfig> alertConfigs = new List<AlertConfig>(){ };

		private string publicCnameMode;

		private string publicUserDomainName;

		private int? ttl;

		private string instanceId;

		private string instanceName;

		private string publicZoneName;

		public string AlertGroup
		{
			get
			{
				return alertGroup;
			}
			set	
			{
				alertGroup = value;
				DictionaryUtil.Add(QueryParameters, "AlertGroup", value);
			}
		}

		public string CnameType
		{
			get
			{
				return cnameType;
			}
			set	
			{
				cnameType = value;
				DictionaryUtil.Add(QueryParameters, "CnameType", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public List<AlertConfig> AlertConfigs
		{
			get
			{
				return alertConfigs;
			}

			set
			{
				alertConfigs = value;
				for (int i = 0; i < alertConfigs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AlertConfig." + (i + 1) + ".SmsNotice", alertConfigs[i].SmsNotice);
					DictionaryUtil.Add(QueryParameters,"AlertConfig." + (i + 1) + ".NoticeType", alertConfigs[i].NoticeType);
					DictionaryUtil.Add(QueryParameters,"AlertConfig." + (i + 1) + ".EmailNotice", alertConfigs[i].EmailNotice);
				}
			}
		}

		public string PublicCnameMode
		{
			get
			{
				return publicCnameMode;
			}
			set	
			{
				publicCnameMode = value;
				DictionaryUtil.Add(QueryParameters, "PublicCnameMode", value);
			}
		}

		public string PublicUserDomainName
		{
			get
			{
				return publicUserDomainName;
			}
			set	
			{
				publicUserDomainName = value;
				DictionaryUtil.Add(QueryParameters, "PublicUserDomainName", value);
			}
		}

		public int? Ttl
		{
			get
			{
				return ttl;
			}
			set	
			{
				ttl = value;
				DictionaryUtil.Add(QueryParameters, "Ttl", value.ToString());
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public string PublicZoneName
		{
			get
			{
				return publicZoneName;
			}
			set	
			{
				publicZoneName = value;
				DictionaryUtil.Add(QueryParameters, "PublicZoneName", value);
			}
		}

		public class AlertConfig
		{

			private bool? smsNotice;

			private string noticeType;

			private bool? emailNotice;

			public bool? SmsNotice
			{
				get
				{
					return smsNotice;
				}
				set	
				{
					smsNotice = value;
				}
			}

			public string NoticeType
			{
				get
				{
					return noticeType;
				}
				set	
				{
					noticeType = value;
				}
			}

			public bool? EmailNotice
			{
				get
				{
					return emailNotice;
				}
				set	
				{
					emailNotice = value;
				}
			}
		}

        public override UpdateDnsGtmInstanceGlobalConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDnsGtmInstanceGlobalConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
