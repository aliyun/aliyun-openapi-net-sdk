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
using Aliyun.Acs.Dts;
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20190901;

namespace Aliyun.Acs.Dts.Model.V20190901
{
    public class ConfigureSynchronizationJobAlertRequest : RpcAcsRequest<ConfigureSynchronizationJobAlertResponse>
    {
        public ConfigureSynchronizationJobAlertRequest()
            : base("Dts", "2019-09-01", "ConfigureSynchronizationJobAlert")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string delayOverSeconds;

		private string delayAlertStatus;

		private string ownerId;

		private string synchronizationJobId;

		private string errorAlertPhone;

		private string delayAlertPhone;

		private string errorAlertStatus;

		private string synchronizationDirection;

		public string DelayOverSeconds
		{
			get
			{
				return delayOverSeconds;
			}
			set	
			{
				delayOverSeconds = value;
				DictionaryUtil.Add(QueryParameters, "DelayOverSeconds", value);
			}
		}

		public string DelayAlertStatus
		{
			get
			{
				return delayAlertStatus;
			}
			set	
			{
				delayAlertStatus = value;
				DictionaryUtil.Add(QueryParameters, "DelayAlertStatus", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string SynchronizationJobId
		{
			get
			{
				return synchronizationJobId;
			}
			set	
			{
				synchronizationJobId = value;
				DictionaryUtil.Add(QueryParameters, "SynchronizationJobId", value);
			}
		}

		public string ErrorAlertPhone
		{
			get
			{
				return errorAlertPhone;
			}
			set	
			{
				errorAlertPhone = value;
				DictionaryUtil.Add(QueryParameters, "ErrorAlertPhone", value);
			}
		}

		public string DelayAlertPhone
		{
			get
			{
				return delayAlertPhone;
			}
			set	
			{
				delayAlertPhone = value;
				DictionaryUtil.Add(QueryParameters, "DelayAlertPhone", value);
			}
		}

		public string ErrorAlertStatus
		{
			get
			{
				return errorAlertStatus;
			}
			set	
			{
				errorAlertStatus = value;
				DictionaryUtil.Add(QueryParameters, "ErrorAlertStatus", value);
			}
		}

		public string SynchronizationDirection
		{
			get
			{
				return synchronizationDirection;
			}
			set	
			{
				synchronizationDirection = value;
				DictionaryUtil.Add(QueryParameters, "SynchronizationDirection", value);
			}
		}

        public override ConfigureSynchronizationJobAlertResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigureSynchronizationJobAlertResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
