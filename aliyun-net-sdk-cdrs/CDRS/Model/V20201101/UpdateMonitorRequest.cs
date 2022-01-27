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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class UpdateMonitorRequest : RpcAcsRequest<UpdateMonitorResponse>
    {
        public UpdateMonitorRequest()
            : base("CDRS", "2020-11-01", "UpdateMonitor")
        {
			Method = MethodType.POST;
        }

		private string corpId;

		private string description;

		private string ruleName;

		private string picOperateType;

		private string attributeName;

		private string attributeOperateType;

		private string ruleExpression;

		private int? notifierTimeOut;

		private string taskId;

		private string deviceOperateType;

		private string picList;

		private string attributeValueList;

		private string notifierAppSecret;

		private string notifierExtendValues;

		private string deviceList;

		private string notifierUrl;

		private string notifierType;

		private string algorithmVendor;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
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
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
				DictionaryUtil.Add(BodyParameters, "RuleName", value);
			}
		}

		public string PicOperateType
		{
			get
			{
				return picOperateType;
			}
			set	
			{
				picOperateType = value;
				DictionaryUtil.Add(BodyParameters, "PicOperateType", value);
			}
		}

		public string AttributeName
		{
			get
			{
				return attributeName;
			}
			set	
			{
				attributeName = value;
				DictionaryUtil.Add(BodyParameters, "AttributeName", value);
			}
		}

		public string AttributeOperateType
		{
			get
			{
				return attributeOperateType;
			}
			set	
			{
				attributeOperateType = value;
				DictionaryUtil.Add(BodyParameters, "AttributeOperateType", value);
			}
		}

		public string RuleExpression
		{
			get
			{
				return ruleExpression;
			}
			set	
			{
				ruleExpression = value;
				DictionaryUtil.Add(BodyParameters, "RuleExpression", value);
			}
		}

		public int? NotifierTimeOut
		{
			get
			{
				return notifierTimeOut;
			}
			set	
			{
				notifierTimeOut = value;
				DictionaryUtil.Add(BodyParameters, "NotifierTimeOut", value.ToString());
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(BodyParameters, "TaskId", value);
			}
		}

		public string DeviceOperateType
		{
			get
			{
				return deviceOperateType;
			}
			set	
			{
				deviceOperateType = value;
				DictionaryUtil.Add(BodyParameters, "DeviceOperateType", value);
			}
		}

		public string PicList
		{
			get
			{
				return picList;
			}
			set	
			{
				picList = value;
				DictionaryUtil.Add(BodyParameters, "PicList", value);
			}
		}

		public string AttributeValueList
		{
			get
			{
				return attributeValueList;
			}
			set	
			{
				attributeValueList = value;
				DictionaryUtil.Add(BodyParameters, "AttributeValueList", value);
			}
		}

		public string NotifierAppSecret
		{
			get
			{
				return notifierAppSecret;
			}
			set	
			{
				notifierAppSecret = value;
				DictionaryUtil.Add(BodyParameters, "NotifierAppSecret", value);
			}
		}

		public string NotifierExtendValues
		{
			get
			{
				return notifierExtendValues;
			}
			set	
			{
				notifierExtendValues = value;
				DictionaryUtil.Add(BodyParameters, "NotifierExtendValues", value);
			}
		}

		public string DeviceList
		{
			get
			{
				return deviceList;
			}
			set	
			{
				deviceList = value;
				DictionaryUtil.Add(BodyParameters, "DeviceList", value);
			}
		}

		public string NotifierUrl
		{
			get
			{
				return notifierUrl;
			}
			set	
			{
				notifierUrl = value;
				DictionaryUtil.Add(BodyParameters, "NotifierUrl", value);
			}
		}

		public string NotifierType
		{
			get
			{
				return notifierType;
			}
			set	
			{
				notifierType = value;
				DictionaryUtil.Add(BodyParameters, "NotifierType", value);
			}
		}

		public string AlgorithmVendor
		{
			get
			{
				return algorithmVendor;
			}
			set	
			{
				algorithmVendor = value;
				DictionaryUtil.Add(BodyParameters, "AlgorithmVendor", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateMonitorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateMonitorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
