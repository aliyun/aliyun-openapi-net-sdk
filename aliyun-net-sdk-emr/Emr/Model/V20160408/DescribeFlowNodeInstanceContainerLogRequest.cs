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
    public class DescribeFlowNodeInstanceContainerLogRequest : RpcAcsRequest<DescribeFlowNodeInstanceContainerLogResponse>
    {
        public DescribeFlowNodeInstanceContainerLogRequest()
            : base("Emr", "2016-04-08", "DescribeFlowNodeInstanceContainerLog", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? offset;

		private string logName;

		private int? length;

		private string nodeInstanceId;

		private string appId;

		private string containerId;

		private string projectId;

		public int? Offset
		{
			get
			{
				return offset;
			}
			set	
			{
				offset = value;
				DictionaryUtil.Add(QueryParameters, "Offset", value.ToString());
			}
		}

		public string LogName
		{
			get
			{
				return logName;
			}
			set	
			{
				logName = value;
				DictionaryUtil.Add(QueryParameters, "LogName", value);
			}
		}

		public int? Length
		{
			get
			{
				return length;
			}
			set	
			{
				length = value;
				DictionaryUtil.Add(QueryParameters, "Length", value.ToString());
			}
		}

		public string NodeInstanceId
		{
			get
			{
				return nodeInstanceId;
			}
			set	
			{
				nodeInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "NodeInstanceId", value);
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

		public string ContainerId
		{
			get
			{
				return containerId;
			}
			set	
			{
				containerId = value;
				DictionaryUtil.Add(QueryParameters, "ContainerId", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

        public override DescribeFlowNodeInstanceContainerLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeFlowNodeInstanceContainerLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
