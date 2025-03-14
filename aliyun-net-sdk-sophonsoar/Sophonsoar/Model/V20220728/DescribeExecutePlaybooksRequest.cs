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
using Aliyun.Acs.sophonsoar;
using Aliyun.Acs.sophonsoar.Transform;
using Aliyun.Acs.sophonsoar.Transform.V20220728;

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
    public class DescribeExecutePlaybooksRequest : RpcAcsRequest<DescribeExecutePlaybooksResponse>
    {
        public DescribeExecutePlaybooksRequest()
            : base("sophonsoar", "2022-07-28", "DescribeExecutePlaybooks")
        {
        }

		private string playbookName;

		private string paramType;

		private string inputMode;

		private string uuid;

		private string lang;

		public string PlaybookName
		{
			get
			{
				return playbookName;
			}
			set	
			{
				playbookName = value;
				DictionaryUtil.Add(QueryParameters, "PlaybookName", value);
			}
		}

		public string ParamType
		{
			get
			{
				return paramType;
			}
			set	
			{
				paramType = value;
				DictionaryUtil.Add(QueryParameters, "ParamType", value);
			}
		}

		public string InputMode
		{
			get
			{
				return inputMode;
			}
			set	
			{
				inputMode = value;
				DictionaryUtil.Add(QueryParameters, "InputMode", value);
			}
		}

		public string Uuid
		{
			get
			{
				return uuid;
			}
			set	
			{
				uuid = value;
				DictionaryUtil.Add(QueryParameters, "Uuid", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeExecutePlaybooksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeExecutePlaybooksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
