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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class DescribeAutomateResponseConfigPlayBooksRequest : RpcAcsRequest<DescribeAutomateResponseConfigPlayBooksResponse>
    {
        public DescribeAutomateResponseConfigPlayBooksRequest()
            : base("cloud-siem", "2022-06-16", "DescribeAutomateResponseConfigPlayBooks", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? roleFor;

		private string autoResponseType;

		private int? roleType;

		private string entityType;

		public long? RoleFor
		{
			get
			{
				return roleFor;
			}
			set	
			{
				roleFor = value;
				DictionaryUtil.Add(BodyParameters, "RoleFor", value.ToString());
			}
		}

		public string AutoResponseType
		{
			get
			{
				return autoResponseType;
			}
			set	
			{
				autoResponseType = value;
				DictionaryUtil.Add(BodyParameters, "AutoResponseType", value);
			}
		}

		public int? RoleType
		{
			get
			{
				return roleType;
			}
			set	
			{
				roleType = value;
				DictionaryUtil.Add(BodyParameters, "RoleType", value.ToString());
			}
		}

		public string EntityType
		{
			get
			{
				return entityType;
			}
			set	
			{
				entityType = value;
				DictionaryUtil.Add(BodyParameters, "EntityType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeAutomateResponseConfigPlayBooksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAutomateResponseConfigPlayBooksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
