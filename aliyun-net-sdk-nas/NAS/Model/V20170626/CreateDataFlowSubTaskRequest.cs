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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class CreateDataFlowSubTaskRequest : RpcAcsRequest<CreateDataFlowSubTaskResponse>
    {
        public CreateDataFlowSubTaskRequest()
            : base("NAS", "2017-06-26", "CreateDataFlowSubTask", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string dataFlowTaskId;

		private string srcFilePath;

		private string fileSystemId;

		private bool? dryRun;

		private string dataFlowId;

		private string dstFilePath;

		private Condition condition_;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string DataFlowTaskId
		{
			get
			{
				return dataFlowTaskId;
			}
			set	
			{
				dataFlowTaskId = value;
				DictionaryUtil.Add(QueryParameters, "DataFlowTaskId", value);
			}
		}

		public string SrcFilePath
		{
			get
			{
				return srcFilePath;
			}
			set	
			{
				srcFilePath = value;
				DictionaryUtil.Add(QueryParameters, "SrcFilePath", value);
			}
		}

		public string FileSystemId
		{
			get
			{
				return fileSystemId;
			}
			set	
			{
				fileSystemId = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemId", value);
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public string DataFlowId
		{
			get
			{
				return dataFlowId;
			}
			set	
			{
				dataFlowId = value;
				DictionaryUtil.Add(QueryParameters, "DataFlowId", value);
			}
		}

		public string DstFilePath
		{
			get
			{
				return dstFilePath;
			}
			set	
			{
				dstFilePath = value;
				DictionaryUtil.Add(QueryParameters, "DstFilePath", value);
			}
		}

		public Condition Condition_
		{
			get
			{
				return condition_;
			}

			set
			{
				condition_ = value;
				if(condition_ != null)
				{

					DictionaryUtil.Add(QueryParameters,"Condition.Size", condition_.Size);
					DictionaryUtil.Add(QueryParameters,"Condition.ModifyTime", condition_.ModifyTime);
				}
			}
		}

		public class Condition
		{

			private long? size;

			private long? modifyTime;

			public long? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public long? ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}
		}

        public override CreateDataFlowSubTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDataFlowSubTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
