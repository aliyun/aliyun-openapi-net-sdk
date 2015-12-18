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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20151101;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
    public class OpsUpgradeInstanceRequest : RpcAcsRequest<OpsUpgradeInstanceResponse>
    {
        public OpsUpgradeInstanceRequest()
            : base("Ecs", "2015-11-01", "OpsUpgradeInstance")
        {
        }

		private string regionNo;

		private string ecsInstanceId;

		private int? cores;

		private int? mem;

		private int? excessivePolicy;

		public string RegionNo
		{
			get
			{
				return regionNo;
			}
			set	
			{
				regionNo = value;
				DictionaryUtil.Add(QueryParameters, "RegionNo", value);
			}
		}

		public string EcsInstanceId
		{
			get
			{
				return ecsInstanceId;
			}
			set	
			{
				ecsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "EcsInstanceId", value);
			}
		}

		public int? Cores
		{
			get
			{
				return cores;
			}
			set	
			{
				cores = value;
				DictionaryUtil.Add(QueryParameters, "Cores", value.ToString());
			}
		}

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

		public int? ExcessivePolicy
		{
			get
			{
				return excessivePolicy;
			}
			set	
			{
				excessivePolicy = value;
				DictionaryUtil.Add(QueryParameters, "ExcessivePolicy", value.ToString());
			}
		}

        public override OpsUpgradeInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OpsUpgradeInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}