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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;
using System.Collections.Generic;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class CPFSCreateFileSystemRequest : RpcAcsRequest<CPFSCreateFileSystemResponse>
    {
        public CPFSCreateFileSystemRequest()
            : base("NAS", "2017-06-26", "CPFSCreateFileSystem", "nas", "openAPI")
        {
        }

		private string fsSpec;

		private string vSwitchId;

		private long? bandwidth;

		private string vpcId;

		private string zoneId;

		private string networkType;

		private string fsDesc;

		private long? capacity;

		public string FsSpec
		{
			get
			{
				return fsSpec;
			}
			set	
			{
				fsSpec = value;
				DictionaryUtil.Add(QueryParameters, "FsSpec", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public long? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
			}
		}

		public string FsDesc
		{
			get
			{
				return fsDesc;
			}
			set	
			{
				fsDesc = value;
				DictionaryUtil.Add(QueryParameters, "FsDesc", value);
			}
		}

		public long? Capacity
		{
			get
			{
				return capacity;
			}
			set	
			{
				capacity = value;
				DictionaryUtil.Add(QueryParameters, "Capacity", value.ToString());
			}
		}

        public override CPFSCreateFileSystemResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CPFSCreateFileSystemResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}