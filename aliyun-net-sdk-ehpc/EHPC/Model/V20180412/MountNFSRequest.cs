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
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class MountNFSRequest : RpcAcsRequest<MountNFSResponse>
    {
        public MountNFSRequest()
            : base("EHPC", "2018-04-12", "MountNFS")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private string mountDir;

		private string instanceId;

		private string remoteDir;

		private string nfsDir;

		private string protocolType;

		public string MountDir
		{
			get
			{
				return mountDir;
			}
			set	
			{
				mountDir = value;
				DictionaryUtil.Add(QueryParameters, "MountDir", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string RemoteDir
		{
			get
			{
				return remoteDir;
			}
			set	
			{
				remoteDir = value;
				DictionaryUtil.Add(QueryParameters, "RemoteDir", value);
			}
		}

		public string NfsDir
		{
			get
			{
				return nfsDir;
			}
			set	
			{
				nfsDir = value;
				DictionaryUtil.Add(QueryParameters, "NfsDir", value);
			}
		}

		public string ProtocolType
		{
			get
			{
				return protocolType;
			}
			set	
			{
				protocolType = value;
				DictionaryUtil.Add(QueryParameters, "ProtocolType", value);
			}
		}

        public override MountNFSResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MountNFSResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
