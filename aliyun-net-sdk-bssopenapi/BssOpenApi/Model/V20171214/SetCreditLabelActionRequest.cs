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
using Aliyun.Acs.BssOpenApi;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class SetCreditLabelActionRequest : RpcAcsRequest<SetCreditLabelActionResponse>
    {
        public SetCreditLabelActionRequest()
            : base("BssOpenApi", "2017-12-14", "SetCreditLabelAction")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string actionType;

		private string isNeedSaveNotifyRule;

		private string isNeedAdjustCreditAccount;

		private bool? newCreateMode;

		private string description;

		private string source;

		private string currencyCode;

		private string dailyCycle;

		private string _operator;

		private string uid;

		private string siteCode;

		private string clearCycle;

		private bool? needNotice;

		private string requestId;

		private string isNeedSetCreditAmount;

		private string creditAmount;

		private string isNeedAddSettleLabel;

		public string ActionType
		{
			get
			{
				return actionType;
			}
			set	
			{
				actionType = value;
				DictionaryUtil.Add(QueryParameters, "ActionType", value);
			}
		}

		public string IsNeedSaveNotifyRule
		{
			get
			{
				return isNeedSaveNotifyRule;
			}
			set	
			{
				isNeedSaveNotifyRule = value;
				DictionaryUtil.Add(QueryParameters, "IsNeedSaveNotifyRule", value);
			}
		}

		public string IsNeedAdjustCreditAccount
		{
			get
			{
				return isNeedAdjustCreditAccount;
			}
			set	
			{
				isNeedAdjustCreditAccount = value;
				DictionaryUtil.Add(QueryParameters, "IsNeedAdjustCreditAccount", value);
			}
		}

		public bool? NewCreateMode
		{
			get
			{
				return newCreateMode;
			}
			set	
			{
				newCreateMode = value;
				DictionaryUtil.Add(QueryParameters, "NewCreateMode", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
				DictionaryUtil.Add(QueryParameters, "Source", value);
			}
		}

		public string CurrencyCode
		{
			get
			{
				return currencyCode;
			}
			set	
			{
				currencyCode = value;
				DictionaryUtil.Add(QueryParameters, "CurrencyCode", value);
			}
		}

		public string DailyCycle
		{
			get
			{
				return dailyCycle;
			}
			set	
			{
				dailyCycle = value;
				DictionaryUtil.Add(QueryParameters, "DailyCycle", value);
			}
		}

		public string _Operator
		{
			get
			{
				return _operator;
			}
			set	
			{
				_operator = value;
				DictionaryUtil.Add(QueryParameters, "Operator", value);
			}
		}

		public string Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value);
			}
		}

		public string SiteCode
		{
			get
			{
				return siteCode;
			}
			set	
			{
				siteCode = value;
				DictionaryUtil.Add(QueryParameters, "SiteCode", value);
			}
		}

		public string ClearCycle
		{
			get
			{
				return clearCycle;
			}
			set	
			{
				clearCycle = value;
				DictionaryUtil.Add(QueryParameters, "ClearCycle", value);
			}
		}

		public bool? NeedNotice
		{
			get
			{
				return needNotice;
			}
			set	
			{
				needNotice = value;
				DictionaryUtil.Add(QueryParameters, "NeedNotice", value.ToString());
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
				DictionaryUtil.Add(QueryParameters, "RequestId", value);
			}
		}

		public string IsNeedSetCreditAmount
		{
			get
			{
				return isNeedSetCreditAmount;
			}
			set	
			{
				isNeedSetCreditAmount = value;
				DictionaryUtil.Add(QueryParameters, "IsNeedSetCreditAmount", value);
			}
		}

		public string CreditAmount
		{
			get
			{
				return creditAmount;
			}
			set	
			{
				creditAmount = value;
				DictionaryUtil.Add(QueryParameters, "CreditAmount", value);
			}
		}

		public string IsNeedAddSettleLabel
		{
			get
			{
				return isNeedAddSettleLabel;
			}
			set	
			{
				isNeedAddSettleLabel = value;
				DictionaryUtil.Add(QueryParameters, "IsNeedAddSettleLabel", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetCreditLabelActionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetCreditLabelActionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
