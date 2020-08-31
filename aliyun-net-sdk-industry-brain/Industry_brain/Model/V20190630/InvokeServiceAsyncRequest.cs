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
using Aliyun.Acs.industry_brain;
using Aliyun.Acs.industry_brain.Transform;
using Aliyun.Acs.industry_brain.Transform.V20190630;

namespace Aliyun.Acs.industry_brain.Model.V20190630
{
    public class InvokeServiceAsyncRequest : RpcAcsRequest<InvokeServiceAsyncResponse>
    {
        public InvokeServiceAsyncRequest()
            : base("industry-brain", "2019-06-30", "InvokeServiceAsync")
        {
			Method = MethodType.POST;
        }

		private bool? isShowInput;

		private string context;

		private string serviceId;

		private string _params;

		private string requestData;

		public bool? IsShowInput
		{
			get
			{
				return isShowInput;
			}
			set	
			{
				isShowInput = value;
				DictionaryUtil.Add(QueryParameters, "IsShowInput", value.ToString());
			}
		}

		public string Context
		{
			get
			{
				return context;
			}
			set	
			{
				context = value;
				DictionaryUtil.Add(QueryParameters, "Context", value);
			}
		}

		public string ServiceId
		{
			get
			{
				return serviceId;
			}
			set	
			{
				serviceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceId", value);
			}
		}

		public string _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
				DictionaryUtil.Add(QueryParameters, "Params", value);
			}
		}

		public string RequestData
		{
			get
			{
				return requestData;
			}
			set	
			{
				requestData = value;
				DictionaryUtil.Add(QueryParameters, "RequestData", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InvokeServiceAsyncResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InvokeServiceAsyncResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
