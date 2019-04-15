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
    public class DescribeQuaraFileResponseUnmarshaller
    {
        public static DescribeQuaraFileResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeQuaraFileResponse describeQuaraFileResponse = new DescribeQuaraFileResponse();

			describeQuaraFileResponse.HttpResponse = context.HttpResponse;
			describeQuaraFileResponse.RequestId = context.StringValue("DescribeQuaraFile.RequestId");
			describeQuaraFileResponse.PageSize = context.IntegerValue("DescribeQuaraFile.PageSize");
			describeQuaraFileResponse.TotalCount = context.IntegerValue("DescribeQuaraFile.TotalCount");
			describeQuaraFileResponse.CurrentPage = context.IntegerValue("DescribeQuaraFile.CurrentPage");

			List<DescribeQuaraFileResponse.DescribeQuaraFile_QuaraFile> describeQuaraFileResponse_quaraFiles = new List<DescribeQuaraFileResponse.DescribeQuaraFile_QuaraFile>();
			for (int i = 0; i < context.Length("DescribeQuaraFile.QuaraFiles.Length"); i++) {
				DescribeQuaraFileResponse.DescribeQuaraFile_QuaraFile quaraFile = new DescribeQuaraFileResponse.DescribeQuaraFile_QuaraFile();
				quaraFile.Path = context.StringValue("DescribeQuaraFile.QuaraFiles["+ i +"].Path");
				quaraFile.EventName = context.StringValue("DescribeQuaraFile.QuaraFiles["+ i +"].EventName");
				quaraFile.Online = context.BooleanValue("DescribeQuaraFile.QuaraFiles["+ i +"].Online");
				quaraFile.EventType = context.StringValue("DescribeQuaraFile.QuaraFiles["+ i +"].EventType");
				quaraFile.Tag = context.StringValue("DescribeQuaraFile.QuaraFiles["+ i +"].Tag");
				quaraFile.Uuid = context.StringValue("DescribeQuaraFile.QuaraFiles["+ i +"].Uuid");
				quaraFile.FileStatus = context.StringValue("DescribeQuaraFile.QuaraFiles["+ i +"].FileStatus");
				quaraFile.Md5 = context.StringValue("DescribeQuaraFile.QuaraFiles["+ i +"].Md5");

				describeQuaraFileResponse_quaraFiles.Add(quaraFile);
			}
			describeQuaraFileResponse.QuaraFiles = describeQuaraFileResponse_quaraFiles;
        
			return describeQuaraFileResponse;
        }
    }
}
