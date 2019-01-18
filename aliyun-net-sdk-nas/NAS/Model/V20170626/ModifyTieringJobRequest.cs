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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;
using System.Collections.Generic;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class ModifyTieringJobRequest : RpcAcsRequest<ModifyTieringJobResponse>
    {
        public ModifyTieringJobRequest()
            : base("NAS", "2017-06-26", "ModifyTieringJob", "nas", "openAPI")
        {
        }

		private string volume;

		private string path;

		private int? hour;

		private string name;

		private int? weekday;

		private string type;

		private bool? recursive;

		private bool? enabled;

		private string policy;

		public string Volume
		{
			get
			{
				return volume;
			}
			set	
			{
				volume = value;
				DictionaryUtil.Add(QueryParameters, "Volume", value);
			}
		}

		public string Path
		{
			get
			{
				return path;
			}
			set	
			{
				path = value;
				DictionaryUtil.Add(QueryParameters, "Path", value);
			}
		}

		public int? Hour
		{
			get
			{
				return hour;
			}
			set	
			{
				hour = value;
				DictionaryUtil.Add(QueryParameters, "Hour", value.ToString());
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

		public int? Weekday
		{
			get
			{
				return weekday;
			}
			set	
			{
				weekday = value;
				DictionaryUtil.Add(QueryParameters, "Weekday", value.ToString());
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

		public bool? Recursive
		{
			get
			{
				return recursive;
			}
			set	
			{
				recursive = value;
				DictionaryUtil.Add(QueryParameters, "Recursive", value.ToString());
			}
		}

		public bool? Enabled
		{
			get
			{
				return enabled;
			}
			set	
			{
				enabled = value;
				DictionaryUtil.Add(QueryParameters, "Enabled", value.ToString());
			}
		}

		public string Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
				DictionaryUtil.Add(QueryParameters, "Policy", value);
			}
		}

        public override ModifyTieringJobResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyTieringJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}