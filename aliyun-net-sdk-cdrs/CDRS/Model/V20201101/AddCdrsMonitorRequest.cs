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
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class AddCdrsMonitorRequest : RpcAcsRequest<AddCdrsMonitorResponse>
    {
        public AddCdrsMonitorRequest()
            : base("CDRS", "2020-11-01", "AddCdrsMonitor")
        {
			Method = MethodType.POST;
        }

		private string monitorType;

		private string corpId;

		private string description;

		private string notifierAppSecret;

		private string notifierExtendValues;

		private string notifierUrl;

		private string notifierType;

		private int? batchIndicator;

		private int? notifierTimeOut;

		private string algorithmVendor;

		public string MonitorType
		{
			get
			{
				return monitorType;
			}
			set	
			{
				monitorType = value;
				DictionaryUtil.Add(BodyParameters, "MonitorType", value);
			}
		}

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

		public int? BatchIndicator
		{
			get
			{
				return batchIndicator;
			}
			set	
			{
				batchIndicator = value;
				DictionaryUtil.Add(BodyParameters, "BatchIndicator", value.ToString());
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

        public override AddCdrsMonitorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCdrsMonitorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
