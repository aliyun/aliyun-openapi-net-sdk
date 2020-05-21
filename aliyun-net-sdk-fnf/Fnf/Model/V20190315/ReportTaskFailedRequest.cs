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
using Aliyun.Acs.fnf;
using Aliyun.Acs.fnf.Transform;
using Aliyun.Acs.fnf.Transform.V20190315;

namespace Aliyun.Acs.fnf.Model.V20190315
{
    public class ReportTaskFailedRequest : RpcAcsRequest<ReportTaskFailedResponse>
    {
        public ReportTaskFailedRequest()
            : base("fnf", "2019-03-15", "ReportTaskFailed")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string cause;

		private string error;

		private string requestId;

		private string taskToken;

		public string Cause
		{
			get
			{
				return cause;
			}
			set	
			{
				cause = value;
				DictionaryUtil.Add(BodyParameters, "Cause", value);
			}
		}

		public string Error
		{
			get
			{
				return error;
			}
			set	
			{
				error = value;
				DictionaryUtil.Add(BodyParameters, "Error", value);
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

		public string TaskToken
		{
			get
			{
				return taskToken;
			}
			set	
			{
				taskToken = value;
				DictionaryUtil.Add(QueryParameters, "TaskToken", value);
			}
		}

        public override ReportTaskFailedResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ReportTaskFailedResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
