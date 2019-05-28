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
    public class ModifyTieringPolicyRequest : RpcAcsRequest<ModifyTieringPolicyResponse>
    {
        public ModifyTieringPolicyRequest()
            : base("NAS", "2017-06-26", "ModifyTieringPolicy", "nas", "openAPI")
        {
        }

		private long? atime;

		private string fileName;

		private long? size;

		private long? recallTime;

		private string name;

		private string description;

		private long? ctime;

		private long? mtime;

		public long? Atime
		{
			get
			{
				return atime;
			}
			set	
			{
				atime = value;
				DictionaryUtil.Add(QueryParameters, "Atime", value.ToString());
			}
		}

		public string FileName
		{
			get
			{
				return fileName;
			}
			set	
			{
				fileName = value;
				DictionaryUtil.Add(QueryParameters, "FileName", value);
			}
		}

		public long? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "Size", value.ToString());
			}
		}

		public long? RecallTime
		{
			get
			{
				return recallTime;
			}
			set	
			{
				recallTime = value;
				DictionaryUtil.Add(QueryParameters, "RecallTime", value.ToString());
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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public long? Ctime
		{
			get
			{
				return ctime;
			}
			set	
			{
				ctime = value;
				DictionaryUtil.Add(QueryParameters, "Ctime", value.ToString());
			}
		}

		public long? Mtime
		{
			get
			{
				return mtime;
			}
			set	
			{
				mtime = value;
				DictionaryUtil.Add(QueryParameters, "Mtime", value.ToString());
			}
		}

        public override ModifyTieringPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyTieringPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
