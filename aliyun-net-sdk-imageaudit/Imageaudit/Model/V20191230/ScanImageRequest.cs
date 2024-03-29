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
    public class ScanImageRequest : RpcAcsRequest<ScanImageResponse>
    {
        public ScanImageRequest()
            : base("imageaudit", "2019-12-30", "ScanImage", "imageaudit", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageaudit.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageaudit.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> scenes = new List<string>(){ };

		private List<string> tasks = new List<string>(){ };

		public List<string> Scenes
		{
			get
			{
				return scenes;
			}

			set
			{
				scenes = value;
			}
		}

		public List<string> Tasks
		{
			get
			{
				return tasks;
			}

			set
			{
				tasks = value;
				if(tasks != null)
				{
					for (int depth1 = 0; depth1 < tasks.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Task." + (depth1 + 1), tasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"Task." + (depth1 + 1), tasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"Task." + (depth1 + 1), tasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"Task." + (depth1 + 1), tasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"Task." + (depth1 + 1), tasks[depth1]);
					}
				}
			}
		}

		public class Task
		{

			private string dataId;

			private string imageURL;

			private int? maxFrames;

			private int? interval;

			private long? imageTimeMillisecond;

			public string DataId
			{
				get
				{
					return dataId;
				}
				set	
				{
					dataId = value;
				}
			}

			public string ImageURL
			{
				get
				{
					return imageURL;
				}
				set	
				{
					imageURL = value;
				}
			}

			public int? MaxFrames
			{
				get
				{
					return maxFrames;
				}
				set	
				{
					maxFrames = value;
				}
			}

			public int? Interval
			{
				get
				{
					return interval;
				}
				set	
				{
					interval = value;
				}
			}

			public long? ImageTimeMillisecond
			{
				get
				{
					return imageTimeMillisecond;
				}
				set	
				{
					imageTimeMillisecond = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ScanImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ScanImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
