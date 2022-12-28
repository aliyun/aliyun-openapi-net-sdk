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
using Aliyun.Acs.es_serverless.Transform;
using Aliyun.Acs.es_serverless.Transform.V20220822;

namespace Aliyun.Acs.es_serverless.Model.V20220822
{
    public class ListDataStreamsRequest : RoaAcsRequest<ListDataStreamsResponse>
    {
        public ListDataStreamsRequest()
            : base("es-serverless", "2022-08-22", "ListDataStreams", "elkxops", "openAPI")
        {
			UriPattern = "/openapi/xops/instances/[appName]/data-streams";
			Method = MethodType.GET;
        }

		private string appName;

		private string dataStreamName;

		private int? pageSize;

		private int? pageNumber;

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(PathParameters, "appName", value);
			}
		}

		public string DataStreamName
		{
			get
			{
				return dataStreamName;
			}
			set	
			{
				dataStreamName = value;
				DictionaryUtil.Add(QueryParameters, "dataStreamName", value);
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
				DictionaryUtil.Add(QueryParameters, "pageSize", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "pageNumber", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDataStreamsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDataStreamsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
