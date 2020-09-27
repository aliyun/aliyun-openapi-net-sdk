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
    public class UpdateDocIndexMetaRequest : RpcAcsRequest<UpdateDocIndexMetaResponse>
    {
        public UpdateDocIndexMetaRequest()
            : base("imm", "2017-09-06", "UpdateDocIndexMeta", "imm", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string project;

		private string uniqueId;

		private string customKey1;

		private string _set;

		private string customKey5;

		private string customKey4;

		private string customKey3;

		private string customKey2;

		private string customKey6;

		private string name;

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

		public string UniqueId
		{
			get
			{
				return uniqueId;
			}
			set	
			{
				uniqueId = value;
				DictionaryUtil.Add(QueryParameters, "UniqueId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateDocIndexMetaResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDocIndexMetaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
