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
    public class CheckFileDeploymentRequest : RpcAcsRequest<CheckFileDeploymentResponse>
    {
        public CheckFileDeploymentRequest()
            : base("dataworks-public", "2020-05-18", "CheckFileDeployment")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string checkDetailUrl;

		private string checkerInstanceId;

		private string status;

		public string CheckDetailUrl
		{
			get
			{
				return checkDetailUrl;
			}
			set	
			{
				checkDetailUrl = value;
				DictionaryUtil.Add(BodyParameters, "CheckDetailUrl", value);
			}
		}

		public string CheckerInstanceId
		{
			get
			{
				return checkerInstanceId;
			}
			set	
			{
				checkerInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "CheckerInstanceId", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CheckFileDeploymentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckFileDeploymentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
