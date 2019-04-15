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
using Aliyun.Acs.aegis.Transform;
using Aliyun.Acs.aegis.Transform.V20161111;

namespace Aliyun.Acs.aegis.Model.V20161111
{
    public class ModifySaveVulBatchRequest : RpcAcsRequest<ModifySaveVulBatchResponse>
    {
        public ModifySaveVulBatchRequest()
            : base("aegis", "2016-11-11", "ModifySaveVulBatch", "vipaegis", "openAPI")
        {
        }

		private string batchName;

		private string aliasName;

		private string statusList;

		private string sourceIp;

		private string level;

		private string resource;

		private string name;

		private string dealed;

		private string remark;

		private string type;

		private string necessity;

		private string uuids;

		public string BatchName
		{
			get
			{
				return batchName;
			}
			set	
			{
				batchName = value;
				DictionaryUtil.Add(QueryParameters, "BatchName", value);
			}
		}

		public string AliasName
		{
			get
			{
				return aliasName;
			}
			set	
			{
				aliasName = value;
				DictionaryUtil.Add(QueryParameters, "AliasName", value);
			}
		}

		public string StatusList
		{
			get
			{
				return statusList;
			}
			set	
			{
				statusList = value;
				DictionaryUtil.Add(QueryParameters, "StatusList", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value);
			}
		}

		public string Resource
		{
			get
			{
				return resource;
			}
			set	
			{
				resource = value;
				DictionaryUtil.Add(QueryParameters, "Resource", value);
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

		public string Dealed
		{
			get
			{
				return dealed;
			}
			set	
			{
				dealed = value;
				DictionaryUtil.Add(QueryParameters, "Dealed", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string Necessity
		{
			get
			{
				return necessity;
			}
			set	
			{
				necessity = value;
				DictionaryUtil.Add(QueryParameters, "Necessity", value);
			}
		}

		public string Uuids
		{
			get
			{
				return uuids;
			}
			set	
			{
				uuids = value;
				DictionaryUtil.Add(QueryParameters, "Uuids", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifySaveVulBatchResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySaveVulBatchResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
