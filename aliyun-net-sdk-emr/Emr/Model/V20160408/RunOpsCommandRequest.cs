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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class RunOpsCommandRequest : RpcAcsRequest<RunOpsCommandResponse>
    {
        public RunOpsCommandRequest()
            : base("Emr", "2016-04-08", "RunOpsCommand", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string regionId;

		private string opsCommandName;

		private string comment;

		private string customParams;

		private string clusterId;

		private List<string> hostIdLists;

		private string dimension;

		private string accessKeyId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string OpsCommandName
		{
			get
			{
				return opsCommandName;
			}
			set	
			{
				opsCommandName = value;
				DictionaryUtil.Add(QueryParameters, "OpsCommandName", value);
			}
		}

		public string Comment
		{
			get
			{
				return comment;
			}
			set	
			{
				comment = value;
				DictionaryUtil.Add(QueryParameters, "Comment", value);
			}
		}

		public string CustomParams
		{
			get
			{
				return customParams;
			}
			set	
			{
				customParams = value;
				DictionaryUtil.Add(QueryParameters, "CustomParams", value);
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

		public List<string> HostIdLists
		{
			get
			{
				return hostIdLists;
			}

			set
			{
				hostIdLists = value;
				for (int i = 0; i < hostIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"HostIdList." + (i + 1) , hostIdLists[i]);
				}
			}
		}

		public string Dimension
		{
			get
			{
				return dimension;
			}
			set	
			{
				dimension = value;
				DictionaryUtil.Add(QueryParameters, "Dimension", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override RunOpsCommandResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunOpsCommandResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
