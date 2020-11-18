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
using Aliyun.Acs.HBase.Transform;
using Aliyun.Acs.HBase.Transform.V20190101;

namespace Aliyun.Acs.HBase.Model.V20190101
{
    public class ResizeMultiZoneClusterNodeCountRequest : RpcAcsRequest<ResizeMultiZoneClusterNodeCountResponse>
    {
        public ResizeMultiZoneClusterNodeCountRequest()
            : base("HBase", "2019-01-01", "ResizeMultiZoneClusterNodeCount", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string primaryVSwitchId;

		private string standbyVSwitchId;

		private int? logNodeCount;

		private string clusterId;

		private int? primaryCoreNodeCount;

		private int? coreNodeCount;

		private int? standbyCoreNodeCount;

		private string arbiterVSwitchId;

		public string PrimaryVSwitchId
		{
			get
			{
				return primaryVSwitchId;
			}
			set	
			{
				primaryVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "PrimaryVSwitchId", value);
			}
		}

		public string StandbyVSwitchId
		{
			get
			{
				return standbyVSwitchId;
			}
			set	
			{
				standbyVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "StandbyVSwitchId", value);
			}
		}

		public int? LogNodeCount
		{
			get
			{
				return logNodeCount;
			}
			set	
			{
				logNodeCount = value;
				DictionaryUtil.Add(QueryParameters, "LogNodeCount", value.ToString());
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

		public int? PrimaryCoreNodeCount
		{
			get
			{
				return primaryCoreNodeCount;
			}
			set	
			{
				primaryCoreNodeCount = value;
				DictionaryUtil.Add(QueryParameters, "PrimaryCoreNodeCount", value.ToString());
			}
		}

		public int? CoreNodeCount
		{
			get
			{
				return coreNodeCount;
			}
			set	
			{
				coreNodeCount = value;
				DictionaryUtil.Add(QueryParameters, "CoreNodeCount", value.ToString());
			}
		}

		public int? StandbyCoreNodeCount
		{
			get
			{
				return standbyCoreNodeCount;
			}
			set	
			{
				standbyCoreNodeCount = value;
				DictionaryUtil.Add(QueryParameters, "StandbyCoreNodeCount", value.ToString());
			}
		}

		public string ArbiterVSwitchId
		{
			get
			{
				return arbiterVSwitchId;
			}
			set	
			{
				arbiterVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "ArbiterVSwitchId", value);
			}
		}

        public override ResizeMultiZoneClusterNodeCountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ResizeMultiZoneClusterNodeCountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
