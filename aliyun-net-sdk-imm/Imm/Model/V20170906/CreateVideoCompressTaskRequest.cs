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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class CreateVideoCompressTaskRequest : RpcAcsRequest<CreateVideoCompressTaskResponse>
    {
        public CreateVideoCompressTaskRequest()
            : base("imm", "2017-09-06", "CreateVideoCompressTask", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string project;

		private string notifyEndpoint;

		private string targetContainer;

		private string customMessage;

		private string notifyTopicName;

		private string targetList;

		private string videoUri;

		private string targetSegment;

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string NotifyEndpoint
		{
			get
			{
				return notifyEndpoint;
			}
			set	
			{
				notifyEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "NotifyEndpoint", value);
			}
		}

		public string TargetContainer
		{
			get
			{
				return targetContainer;
			}
			set	
			{
				targetContainer = value;
				DictionaryUtil.Add(QueryParameters, "TargetContainer", value);
			}
		}

		public string CustomMessage
		{
			get
			{
				return customMessage;
			}
			set	
			{
				customMessage = value;
				DictionaryUtil.Add(QueryParameters, "CustomMessage", value);
			}
		}

		public string NotifyTopicName
		{
			get
			{
				return notifyTopicName;
			}
			set	
			{
				notifyTopicName = value;
				DictionaryUtil.Add(QueryParameters, "NotifyTopicName", value);
			}
		}

		public string TargetList
		{
			get
			{
				return targetList;
			}
			set	
			{
				targetList = value;
				DictionaryUtil.Add(QueryParameters, "TargetList", value);
			}
		}

		public string VideoUri
		{
			get
			{
				return videoUri;
			}
			set	
			{
				videoUri = value;
				DictionaryUtil.Add(QueryParameters, "VideoUri", value);
			}
		}

		public string TargetSegment
		{
			get
			{
				return targetSegment;
			}
			set	
			{
				targetSegment = value;
				DictionaryUtil.Add(QueryParameters, "TargetSegment", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVideoCompressTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVideoCompressTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
