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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class CreateStreamSnapshotResponseUnmarshaller
    {
        public static CreateStreamSnapshotResponse Unmarshall(UnmarshallerContext context)
        {
			CreateStreamSnapshotResponse createStreamSnapshotResponse = new CreateStreamSnapshotResponse();

			createStreamSnapshotResponse.HttpResponse = context.HttpResponse;
			createStreamSnapshotResponse.RequestId = context.StringValue("CreateStreamSnapshot.RequestId");
			createStreamSnapshotResponse.Id = context.StringValue("CreateStreamSnapshot.Id");
			createStreamSnapshotResponse.Url = context.StringValue("CreateStreamSnapshot.Url");
			createStreamSnapshotResponse.OssBucket = context.StringValue("CreateStreamSnapshot.OssBucket");
			createStreamSnapshotResponse.OssObject = context.StringValue("CreateStreamSnapshot.OssObject");
			createStreamSnapshotResponse.OssEndpoint = context.StringValue("CreateStreamSnapshot.OssEndpoint");
			createStreamSnapshotResponse.Height = context.LongValue("CreateStreamSnapshot.Height");
			createStreamSnapshotResponse.Width = context.LongValue("CreateStreamSnapshot.Width");
			createStreamSnapshotResponse.Format = context.StringValue("CreateStreamSnapshot.Format");
			createStreamSnapshotResponse.Timestamp = context.LongValue("CreateStreamSnapshot.Timestamp");
        
			return createStreamSnapshotResponse;
        }
    }
}
