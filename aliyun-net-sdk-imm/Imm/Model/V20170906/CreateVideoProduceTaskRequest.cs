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
    public class CreateVideoProduceTaskRequest : RpcAcsRequest<CreateVideoProduceTaskResponse>
    {
        public CreateVideoProduceTaskRequest()
            : base("imm", "2017-09-06", "CreateVideoProduceTask", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string project;

		private string music;

		private string notifyEndpoint;

		private string targetUri;

		private string templateName;

		private int? height;

		private string customMessage;

		private string images;

		private string notifyTopicName;

		private int? width;

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

		public string Music
		{
			get
			{
				return music;
			}
			set	
			{
				music = value;
				DictionaryUtil.Add(QueryParameters, "Music", value);
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

		public string TargetUri
		{
			get
			{
				return targetUri;
			}
			set	
			{
				targetUri = value;
				DictionaryUtil.Add(QueryParameters, "TargetUri", value);
			}
		}

		public string TemplateName
		{
			get
			{
				return templateName;
			}
			set	
			{
				templateName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
			}
		}

		public int? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(QueryParameters, "Height", value.ToString());
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

		public string Images
		{
			get
			{
				return images;
			}
			set	
			{
				images = value;
				DictionaryUtil.Add(QueryParameters, "Images", value);
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

		public int? Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(QueryParameters, "Width", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVideoProduceTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVideoProduceTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
