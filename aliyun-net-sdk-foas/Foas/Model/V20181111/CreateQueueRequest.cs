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
using Aliyun.Acs.foas.Transform;
using Aliyun.Acs.foas.Transform.V20181111;

namespace Aliyun.Acs.foas.Model.V20181111
{
    public class CreateQueueRequest : RoaAcsRequest<CreateQueueResponse>
    {
        public CreateQueueRequest()
            : base("foas", "2018-11-11", "CreateQueue", "foas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v2/clusters/[clusterId]/queue";
			Method = MethodType.POST;
        }

		private string queueName;

		private int? maxMemMB;

		private string clusterId;

		private int? gpu;

		private int? maxVcore;

		public string QueueName
		{
			get
			{
				return queueName;
			}
			set	
			{
				queueName = value;
				DictionaryUtil.Add(BodyParameters, "queueName", value);
			}
		}

		public int? MaxMemMB
		{
			get
			{
				return maxMemMB;
			}
			set	
			{
				maxMemMB = value;
				DictionaryUtil.Add(BodyParameters, "maxMemMB", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(PathParameters, "clusterId", value);
			}
		}

		public int? Gpu
		{
			get
			{
				return gpu;
			}
			set	
			{
				gpu = value;
				DictionaryUtil.Add(BodyParameters, "gpu", value.ToString());
			}
		}

		public int? MaxVcore
		{
			get
			{
				return maxVcore;
			}
			set	
			{
				maxVcore = value;
				DictionaryUtil.Add(BodyParameters, "maxVcore", value.ToString());
			}
		}

        public override CreateQueueResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateQueueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
