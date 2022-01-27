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
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class ConfigureSubscriptionRequest : RpcAcsRequest<ConfigureSubscriptionResponse>
    {
        public ConfigureSubscriptionRequest()
            : base("Dts", "2020-01-01", "ConfigureSubscription", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceEndpointRegion;

		private string checkpoint;

		private string subscriptionInstanceVSwitchId;

		private bool? delayNotice;

		private string sourceEndpointInstanceID;

		private string sourceEndpointUserName;

		private string sourceEndpointOwnerID;

		private string delayPhone;

		private bool? subscriptionDataTypeDML;

		private string sourceEndpointDatabaseName;

		private string sourceEndpointIP;

		private string errorPhone;

		private string reserve;

		private string dtsJobId;

		private string dbList;

		private string subscriptionInstanceNetworkType;

		private bool? subscriptionDataTypeDDL;

		private string sourceEndpointPassword;

		private string sourceEndpointPort;

		private string subscriptionInstanceVPCId;

		private long? delayRuleTime;

		private string sourceEndpointInstanceType;

		private string dtsJobName;

		private string sourceEndpointOracleSID;

		private bool? errorNotice;

		private string sourceEndpointRole;

		private string dtsInstanceId;

		private string sourceEndpointEngineName;

		public string SourceEndpointRegion
		{
			get
			{
				return sourceEndpointRegion;
			}
			set	
			{
				sourceEndpointRegion = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointRegion", value);
			}
		}

		public string Checkpoint
		{
			get
			{
				return checkpoint;
			}
			set	
			{
				checkpoint = value;
				DictionaryUtil.Add(QueryParameters, "Checkpoint", value);
			}
		}

		public string SubscriptionInstanceVSwitchId
		{
			get
			{
				return subscriptionInstanceVSwitchId;
			}
			set	
			{
				subscriptionInstanceVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionInstanceVSwitchId", value);
			}
		}

		public bool? DelayNotice
		{
			get
			{
				return delayNotice;
			}
			set	
			{
				delayNotice = value;
				DictionaryUtil.Add(QueryParameters, "DelayNotice", value.ToString());
			}
		}

		public string SourceEndpointInstanceID
		{
			get
			{
				return sourceEndpointInstanceID;
			}
			set	
			{
				sourceEndpointInstanceID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointInstanceID", value);
			}
		}

		public string SourceEndpointUserName
		{
			get
			{
				return sourceEndpointUserName;
			}
			set	
			{
				sourceEndpointUserName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointUserName", value);
			}
		}

		public string SourceEndpointOwnerID
		{
			get
			{
				return sourceEndpointOwnerID;
			}
			set	
			{
				sourceEndpointOwnerID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointOwnerID", value);
			}
		}

		public string DelayPhone
		{
			get
			{
				return delayPhone;
			}
			set	
			{
				delayPhone = value;
				DictionaryUtil.Add(QueryParameters, "DelayPhone", value);
			}
		}

		public bool? SubscriptionDataTypeDML
		{
			get
			{
				return subscriptionDataTypeDML;
			}
			set	
			{
				subscriptionDataTypeDML = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionDataTypeDML", value.ToString());
			}
		}

		public string SourceEndpointDatabaseName
		{
			get
			{
				return sourceEndpointDatabaseName;
			}
			set	
			{
				sourceEndpointDatabaseName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointDatabaseName", value);
			}
		}

		public string SourceEndpointIP
		{
			get
			{
				return sourceEndpointIP;
			}
			set	
			{
				sourceEndpointIP = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointIP", value);
			}
		}

		public string ErrorPhone
		{
			get
			{
				return errorPhone;
			}
			set	
			{
				errorPhone = value;
				DictionaryUtil.Add(QueryParameters, "ErrorPhone", value);
			}
		}

		public string Reserve
		{
			get
			{
				return reserve;
			}
			set	
			{
				reserve = value;
				DictionaryUtil.Add(QueryParameters, "Reserve", value);
			}
		}

		public string DtsJobId
		{
			get
			{
				return dtsJobId;
			}
			set	
			{
				dtsJobId = value;
				DictionaryUtil.Add(QueryParameters, "DtsJobId", value);
			}
		}

		public string DbList
		{
			get
			{
				return dbList;
			}
			set	
			{
				dbList = value;
				DictionaryUtil.Add(QueryParameters, "DbList", value);
			}
		}

		public string SubscriptionInstanceNetworkType
		{
			get
			{
				return subscriptionInstanceNetworkType;
			}
			set	
			{
				subscriptionInstanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionInstanceNetworkType", value);
			}
		}

		public bool? SubscriptionDataTypeDDL
		{
			get
			{
				return subscriptionDataTypeDDL;
			}
			set	
			{
				subscriptionDataTypeDDL = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionDataTypeDDL", value.ToString());
			}
		}

		public string SourceEndpointPassword
		{
			get
			{
				return sourceEndpointPassword;
			}
			set	
			{
				sourceEndpointPassword = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointPassword", value);
			}
		}

		public string SourceEndpointPort
		{
			get
			{
				return sourceEndpointPort;
			}
			set	
			{
				sourceEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointPort", value);
			}
		}

		public string SubscriptionInstanceVPCId
		{
			get
			{
				return subscriptionInstanceVPCId;
			}
			set	
			{
				subscriptionInstanceVPCId = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionInstanceVPCId", value);
			}
		}

		public long? DelayRuleTime
		{
			get
			{
				return delayRuleTime;
			}
			set	
			{
				delayRuleTime = value;
				DictionaryUtil.Add(QueryParameters, "DelayRuleTime", value.ToString());
			}
		}

		public string SourceEndpointInstanceType
		{
			get
			{
				return sourceEndpointInstanceType;
			}
			set	
			{
				sourceEndpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointInstanceType", value);
			}
		}

		public string DtsJobName
		{
			get
			{
				return dtsJobName;
			}
			set	
			{
				dtsJobName = value;
				DictionaryUtil.Add(QueryParameters, "DtsJobName", value);
			}
		}

		public string SourceEndpointOracleSID
		{
			get
			{
				return sourceEndpointOracleSID;
			}
			set	
			{
				sourceEndpointOracleSID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointOracleSID", value);
			}
		}

		public bool? ErrorNotice
		{
			get
			{
				return errorNotice;
			}
			set	
			{
				errorNotice = value;
				DictionaryUtil.Add(QueryParameters, "ErrorNotice", value.ToString());
			}
		}

		public string SourceEndpointRole
		{
			get
			{
				return sourceEndpointRole;
			}
			set	
			{
				sourceEndpointRole = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointRole", value);
			}
		}

		public string DtsInstanceId
		{
			get
			{
				return dtsInstanceId;
			}
			set	
			{
				dtsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DtsInstanceId", value);
			}
		}

		public string SourceEndpointEngineName
		{
			get
			{
				return sourceEndpointEngineName;
			}
			set	
			{
				sourceEndpointEngineName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointEngineName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ConfigureSubscriptionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigureSubscriptionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
