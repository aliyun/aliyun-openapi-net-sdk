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
using Aliyun.Acs.Actiontrail.Transform;
using Aliyun.Acs.Actiontrail.Transform.V20200706;

namespace Aliyun.Acs.Actiontrail.Model.V20200706
{
    public class CreateTrailRequest : RpcAcsRequest<CreateTrailResponse>
    {
        public CreateTrailRequest()
            : base("Actiontrail", "2020-07-06", "CreateTrail", "actiontrail", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Actiontrail.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Actiontrail.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string slsProjectArn;

		private string slsWriteRoleArn;

		private bool? isOrganizationTrail;

		private string ossKeyPrefix;

		private string ossWriteRoleArn;

		private string eventRW;

		private string name;

		private string ossBucketName;

		private string trailRegion;

		public string SlsProjectArn
		{
			get
			{
				return slsProjectArn;
			}
			set	
			{
				slsProjectArn = value;
				DictionaryUtil.Add(QueryParameters, "SlsProjectArn", value);
			}
		}

		public string SlsWriteRoleArn
		{
			get
			{
				return slsWriteRoleArn;
			}
			set	
			{
				slsWriteRoleArn = value;
				DictionaryUtil.Add(QueryParameters, "SlsWriteRoleArn", value);
			}
		}

		public bool? IsOrganizationTrail
		{
			get
			{
				return isOrganizationTrail;
			}
			set	
			{
				isOrganizationTrail = value;
				DictionaryUtil.Add(QueryParameters, "IsOrganizationTrail", value.ToString());
			}
		}

		public string OssKeyPrefix
		{
			get
			{
				return ossKeyPrefix;
			}
			set	
			{
				ossKeyPrefix = value;
				DictionaryUtil.Add(QueryParameters, "OssKeyPrefix", value);
			}
		}

		public string OssWriteRoleArn
		{
			get
			{
				return ossWriteRoleArn;
			}
			set	
			{
				ossWriteRoleArn = value;
				DictionaryUtil.Add(QueryParameters, "OssWriteRoleArn", value);
			}
		}

		public string EventRW
		{
			get
			{
				return eventRW;
			}
			set	
			{
				eventRW = value;
				DictionaryUtil.Add(QueryParameters, "EventRW", value);
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

		public string OssBucketName
		{
			get
			{
				return ossBucketName;
			}
			set	
			{
				ossBucketName = value;
				DictionaryUtil.Add(QueryParameters, "OssBucketName", value);
			}
		}

		public string TrailRegion
		{
			get
			{
				return trailRegion;
			}
			set	
			{
				trailRegion = value;
				DictionaryUtil.Add(QueryParameters, "TrailRegion", value);
			}
		}

        public override CreateTrailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTrailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
