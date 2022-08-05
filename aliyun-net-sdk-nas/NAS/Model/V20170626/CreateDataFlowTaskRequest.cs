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
    public class CreateDataFlowTaskRequest : RpcAcsRequest<CreateDataFlowTaskResponse>
    {
        public CreateDataFlowTaskRequest()
            : base("NAS", "2017-06-26", "CreateDataFlowTask", "NAS", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string directory;

		private string srcTaskId;

		private string dataType;

		private string fileSystemId;

		private bool? dryRun;

		private string dataFlowId;

		private string entryList;

		private string taskAction;

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

		public string Directory
		{
			get
			{
				return directory;
			}
			set	
			{
				directory = value;
				DictionaryUtil.Add(QueryParameters, "Directory", value);
			}
		}

		public string SrcTaskId
		{
			get
			{
				return srcTaskId;
			}
			set	
			{
				srcTaskId = value;
				DictionaryUtil.Add(QueryParameters, "SrcTaskId", value);
			}
		}

		public string DataType
		{
			get
			{
				return dataType;
			}
			set	
			{
				dataType = value;
				DictionaryUtil.Add(QueryParameters, "DataType", value);
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

		public string EntryList
		{
			get
			{
				return entryList;
			}
			set	
			{
				entryList = value;
				DictionaryUtil.Add(QueryParameters, "EntryList", value);
			}
		}

		public string TaskAction
		{
			get
			{
				return taskAction;
			}
			set	
			{
				taskAction = value;
				DictionaryUtil.Add(QueryParameters, "TaskAction", value);
			}
		}

        public override CreateDataFlowTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDataFlowTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
