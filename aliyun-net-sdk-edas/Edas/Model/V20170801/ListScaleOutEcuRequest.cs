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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class ListScaleOutEcuRequest : RoaAcsRequest<ListScaleOutEcuResponse>
    {
        public ListScaleOutEcuRequest()
            : base("Edas", "2017-08-01", "ListScaleOutEcu", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/resource/scale_out_ecu_list";
			Method = MethodType.POST;
        }

		private int? mem;

		private string logicalRegionId;

		private string appId;

		private string groupId;

		private int? instanceNum;

		private int? cpu;

		private string clusterId;

		public int? Mem
		{
			get
			{
				return mem;
			}
			set	
			{
				mem = value;
				DictionaryUtil.Add(QueryParameters, "Mem", value.ToString());
			}
		}

		public string LogicalRegionId
		{
			get
			{
				return logicalRegionId;
			}
			set	
			{
				logicalRegionId = value;
				DictionaryUtil.Add(QueryParameters, "LogicalRegionId", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public int? InstanceNum
		{
			get
			{
				return instanceNum;
			}
			set	
			{
				instanceNum = value;
				DictionaryUtil.Add(QueryParameters, "InstanceNum", value.ToString());
			}
		}

		public int? Cpu
		{
			get
			{
				return cpu;
			}
			set	
			{
				cpu = value;
				DictionaryUtil.Add(QueryParameters, "Cpu", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

        public override ListScaleOutEcuResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListScaleOutEcuResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
