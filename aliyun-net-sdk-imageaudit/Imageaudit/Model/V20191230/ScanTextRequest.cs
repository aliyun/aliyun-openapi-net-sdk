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
using Aliyun.Acs.imageaudit.Transform;
using Aliyun.Acs.imageaudit.Transform.V20191230;

namespace Aliyun.Acs.imageaudit.Model.V20191230
{
    public class ScanTextRequest : RpcAcsRequest<ScanTextResponse>
    {
        public ScanTextRequest()
            : base("imageaudit", "2019-12-30", "ScanText", "imageaudit", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageaudit.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageaudit.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> labelss = new List<string>(){ };

		private List<string> taskss = new List<string>(){ };

		public List<string> Labelss
		{
			get
			{
				return labelss;
			}

			set
			{
				labelss = value;
				if(labelss != null)
				{
					for (int depth1 = 0; depth1 < labelss.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Labels." + (depth1 + 1), labelss[depth1]);
					}
				}
			}
		}

		public List<string> Taskss
		{
			get
			{
				return taskss;
			}

			set
			{
				taskss = value;
				if(taskss != null)
				{
					for (int depth1 = 0; depth1 < taskss.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Tasks." + (depth1 + 1), taskss[depth1]);
					}
				}
			}
		}

		public class Labels
		{

			private string label;

			public string Label
			{
				get
				{
					return label;
				}
				set	
				{
					label = value;
				}
			}
		}

		public class Tasks
		{

			private string content;

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ScanTextResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ScanTextResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
