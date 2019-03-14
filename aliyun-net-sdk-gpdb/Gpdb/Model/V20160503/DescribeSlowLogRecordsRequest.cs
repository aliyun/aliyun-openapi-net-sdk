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
using Aliyun.Acs.gpdb.Transform;
using Aliyun.Acs.gpdb.Transform.V20160503;

namespace Aliyun.Acs.gpdb.Model.V20160503
{
    public class DescribeSlowLogRecordsRequest : RpcAcsRequest<DescribeSlowLogRecordsResponse>
    {
        public DescribeSlowLogRecordsRequest()
            : base("gpdb", "2016-05-03", "DescribeSlowLogRecords", "gpdb", "openAPI")
        {
        }

		private long? sQLId;

		private string dBName;

		private int? pageSize;

		private string endTime;

		private string dBInstanceId;

		private string startTime;

		private int? pageNumber;

		private string accessKeyId;

		public long? SQLId
		{
			get
			{
				return sQLId;
			}
			set	
			{
				sQLId = value;
				DictionaryUtil.Add(QueryParameters, "SQLId", value.ToString());
			}
		}

		public string DBName
		{
			get
			{
				return dBName;
			}
			set	
			{
				dBName = value;
				DictionaryUtil.Add(QueryParameters, "DBName", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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

        public override DescribeSlowLogRecordsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSlowLogRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
