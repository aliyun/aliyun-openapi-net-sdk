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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class UpdateWorkbenchEventResultRequest : RpcAcsRequest<UpdateWorkbenchEventResultResponse>
    {
        public UpdateWorkbenchEventResultRequest()
            : base("dataworks-public", "2020-05-18", "UpdateWorkbenchEventResult")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string checkResultTip;

		private string checkResult;

		private string messageId;

		private string extensionCode;

		public string CheckResultTip
		{
			get
			{
				return checkResultTip;
			}
			set	
			{
				checkResultTip = value;
				DictionaryUtil.Add(QueryParameters, "CheckResultTip", value);
			}
		}

		public string CheckResult
		{
			get
			{
				return checkResult;
			}
			set	
			{
				checkResult = value;
				DictionaryUtil.Add(QueryParameters, "CheckResult", value);
			}
		}

		public string MessageId
		{
			get
			{
				return messageId;
			}
			set	
			{
				messageId = value;
				DictionaryUtil.Add(QueryParameters, "MessageId", value);
			}
		}

		public string ExtensionCode
		{
			get
			{
				return extensionCode;
			}
			set	
			{
				extensionCode = value;
				DictionaryUtil.Add(QueryParameters, "ExtensionCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateWorkbenchEventResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateWorkbenchEventResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
