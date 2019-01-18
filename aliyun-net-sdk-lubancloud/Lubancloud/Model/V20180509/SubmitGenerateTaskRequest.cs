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
using Aliyun.Acs.lubancloud.Transform;
using Aliyun.Acs.lubancloud.Transform.V20180509;
using System.Collections.Generic;

namespace Aliyun.Acs.lubancloud.Model.V20180509
{
    public class SubmitGenerateTaskRequest : RpcAcsRequest<SubmitGenerateTaskResponse>
    {
        public SubmitGenerateTaskRequest()
            : base("lubancloud", "2018-05-09", "SubmitGenerateTask", "luban", "openAPI")
        {
			Method = MethodType.POST;
        }

		private int? imageCount;

		private string actionPoint;

		private string logoImagePath;

		private int? type;

		private List<string> majorImagePaths;

		private int? width;

		private List<string> copyWrites;

		private List<long?> propertyIds;

		private int? height;

		public int? ImageCount
		{
			get
			{
				return imageCount;
			}
			set	
			{
				imageCount = value;
				DictionaryUtil.Add(QueryParameters, "ImageCount", value.ToString());
			}
		}

		public string ActionPoint
		{
			get
			{
				return actionPoint;
			}
			set	
			{
				actionPoint = value;
				DictionaryUtil.Add(QueryParameters, "ActionPoint", value);
			}
		}

		public string LogoImagePath
		{
			get
			{
				return logoImagePath;
			}
			set	
			{
				logoImagePath = value;
				DictionaryUtil.Add(QueryParameters, "LogoImagePath", value);
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		public List<string> MajorImagePaths
		{
			get
			{
				return majorImagePaths;
			}

			set
			{
				majorImagePaths = value;
				for (int i = 0; i < majorImagePaths.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MajorImagePath." + (i + 1) , majorImagePaths[i]);
				}
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

		public List<string> CopyWrites
		{
			get
			{
				return copyWrites;
			}

			set
			{
				copyWrites = value;
				for (int i = 0; i < copyWrites.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"CopyWrite." + (i + 1) , copyWrites[i]);
				}
			}
		}

		public List<long?> PropertyIds
		{
			get
			{
				return propertyIds;
			}

			set
			{
				propertyIds = value;
				for (int i = 0; i < propertyIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PropertyId." + (i + 1) , propertyIds[i]);
				}
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitGenerateTaskResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SubmitGenerateTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}