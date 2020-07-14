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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class CopyThingModelRequest : RpcAcsRequest<CopyThingModelResponse>
    {
        public CopyThingModelRequest()
            : base("Iot", "2018-01-20", "CopyThingModel", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string targetProductKey;

		private string resourceGroupId;

		private string iotInstanceId;

		private string sourceModelVersion;

		private string sourceProductKey;

		public string TargetProductKey
		{
			get
			{
				return targetProductKey;
			}
			set	
			{
				targetProductKey = value;
				DictionaryUtil.Add(QueryParameters, "TargetProductKey", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string SourceModelVersion
		{
			get
			{
				return sourceModelVersion;
			}
			set	
			{
				sourceModelVersion = value;
				DictionaryUtil.Add(QueryParameters, "SourceModelVersion", value);
			}
		}

		public string SourceProductKey
		{
			get
			{
				return sourceProductKey;
			}
			set	
			{
				sourceProductKey = value;
				DictionaryUtil.Add(QueryParameters, "SourceProductKey", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CopyThingModelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CopyThingModelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
