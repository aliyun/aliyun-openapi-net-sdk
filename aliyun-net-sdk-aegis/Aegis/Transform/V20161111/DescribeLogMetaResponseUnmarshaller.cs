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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeLogMetaResponseUnmarshaller
    {
        public static DescribeLogMetaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLogMetaResponse describeLogMetaResponse = new DescribeLogMetaResponse();

			describeLogMetaResponse.HttpResponse = context.HttpResponse;
			describeLogMetaResponse.RequestId = context.StringValue("DescribeLogMeta.RequestId");
			describeLogMetaResponse.TotalCount = context.IntegerValue("DescribeLogMeta.TotalCount");

			List<DescribeLogMetaResponse.DescribeLogMeta_LogMeta> describeLogMetaResponse_logMetaList = new List<DescribeLogMetaResponse.DescribeLogMeta_LogMeta>();
			for (int i = 0; i < context.Length("DescribeLogMeta.LogMetaList.Length"); i++) {
				DescribeLogMetaResponse.DescribeLogMeta_LogMeta logMeta = new DescribeLogMetaResponse.DescribeLogMeta_LogMeta();
				logMeta.Project = context.StringValue("DescribeLogMeta.LogMetaList["+ i +"].Project");
				logMeta.UserProject = context.StringValue("DescribeLogMeta.LogMetaList["+ i +"].UserProject");
				logMeta.LogStore = context.StringValue("DescribeLogMeta.LogMetaList["+ i +"].LogStore");
				logMeta.LogDesc = context.StringValue("DescribeLogMeta.LogMetaList["+ i +"].LogDesc");
				logMeta.Category = context.StringValue("DescribeLogMeta.LogMetaList["+ i +"].Category");
				logMeta.Status = context.StringValue("DescribeLogMeta.LogMetaList["+ i +"].Status");

				describeLogMetaResponse_logMetaList.Add(logMeta);
			}
			describeLogMetaResponse.LogMetaList = describeLogMetaResponse_logMetaList;
        
			return describeLogMetaResponse;
        }
    }
}
