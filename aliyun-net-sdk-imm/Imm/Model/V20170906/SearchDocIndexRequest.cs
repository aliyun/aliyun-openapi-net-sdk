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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class SearchDocIndexRequest : RpcAcsRequest<SearchDocIndexResponse>
    {
        public SearchDocIndexRequest()
            : base("imm", "2017-09-06", "SearchDocIndex", "2017-09-06", "openAPI")
        {
        }

		private int? modifiedTimeEnd;

		private string customKey1;

		private string _set;

		private int? sizeLimitEnd;

		private string customKey5;

		private int? offset;

		private string customKey4;

		private string customKey3;

		private string customKey2;

		private string project;

		private int? modifiedTimeStart;

		private int? pageNumLimitStart;

		private string customKey6;

		private string content;

		private int? pageNumLimitEnd;

		private string accessKeyId;

		private string contentType;

		private int? sizeLimitStart;

		private string name;

		private int? limit;

		private string action;

		public int? ModifiedTimeEnd
		{
			get
			{
				return modifiedTimeEnd;
			}
			set	
			{
				modifiedTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "ModifiedTimeEnd", value.ToString());
			}
		}

		public string CustomKey1
		{
			get
			{
				return customKey1;
			}
			set	
			{
				customKey1 = value;
				DictionaryUtil.Add(QueryParameters, "CustomKey1", value);
			}
		}

		public string _Set
		{
			get
			{
				return _set;
			}
			set	
			{
				_set = value;
				DictionaryUtil.Add(QueryParameters, "Set", value);
			}
		}

		public int? SizeLimitEnd
		{
			get
			{
				return sizeLimitEnd;
			}
			set	
			{
				sizeLimitEnd = value;
				DictionaryUtil.Add(QueryParameters, "SizeLimitEnd", value.ToString());
			}
		}

		public string CustomKey5
		{
			get
			{
				return customKey5;
			}
			set	
			{
				customKey5 = value;
				DictionaryUtil.Add(QueryParameters, "CustomKey5", value);
			}
		}

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

		public string CustomKey4
		{
			get
			{
				return customKey4;
			}
			set	
			{
				customKey4 = value;
				DictionaryUtil.Add(QueryParameters, "CustomKey4", value);
			}
		}

		public string CustomKey3
		{
			get
			{
				return customKey3;
			}
			set	
			{
				customKey3 = value;
				DictionaryUtil.Add(QueryParameters, "CustomKey3", value);
			}
		}

		public string CustomKey2
		{
			get
			{
				return customKey2;
			}
			set	
			{
				customKey2 = value;
				DictionaryUtil.Add(QueryParameters, "CustomKey2", value);
			}
		}

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

		public int? ModifiedTimeStart
		{
			get
			{
				return modifiedTimeStart;
			}
			set	
			{
				modifiedTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "ModifiedTimeStart", value.ToString());
			}
		}

		public int? PageNumLimitStart
		{
			get
			{
				return pageNumLimitStart;
			}
			set	
			{
				pageNumLimitStart = value;
				DictionaryUtil.Add(QueryParameters, "PageNumLimitStart", value.ToString());
			}
		}

		public string CustomKey6
		{
			get
			{
				return customKey6;
			}
			set	
			{
				customKey6 = value;
				DictionaryUtil.Add(QueryParameters, "CustomKey6", value);
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(QueryParameters, "Content", value);
			}
		}

		public int? PageNumLimitEnd
		{
			get
			{
				return pageNumLimitEnd;
			}
			set	
			{
				pageNumLimitEnd = value;
				DictionaryUtil.Add(QueryParameters, "PageNumLimitEnd", value.ToString());
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

		public string ContentType
		{
			get
			{
				return contentType;
			}
			set	
			{
				contentType = value;
				DictionaryUtil.Add(QueryParameters, "ContentType", value);
			}
		}

		public int? SizeLimitStart
		{
			get
			{
				return sizeLimitStart;
			}
			set	
			{
				sizeLimitStart = value;
				DictionaryUtil.Add(QueryParameters, "SizeLimitStart", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchDocIndexResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SearchDocIndexResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}