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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class GetDirectoryOrFilePropertiesResponseUnmarshaller
    {
        public static GetDirectoryOrFilePropertiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDirectoryOrFilePropertiesResponse getDirectoryOrFilePropertiesResponse = new GetDirectoryOrFilePropertiesResponse();

			getDirectoryOrFilePropertiesResponse.HttpResponse = _ctx.HttpResponse;
			getDirectoryOrFilePropertiesResponse.RequestId = _ctx.StringValue("GetDirectoryOrFileProperties.RequestId");

			GetDirectoryOrFilePropertiesResponse.GetDirectoryOrFileProperties_Entry entry = new GetDirectoryOrFilePropertiesResponse.GetDirectoryOrFileProperties_Entry();
			entry.Type = _ctx.StringValue("GetDirectoryOrFileProperties.Entry.Type");
			entry.HasInfrequentAccessFile = _ctx.BooleanValue("GetDirectoryOrFileProperties.Entry.HasInfrequentAccessFile");
			entry.MTime = _ctx.StringValue("GetDirectoryOrFileProperties.Entry.MTime");
			entry.ATime = _ctx.StringValue("GetDirectoryOrFileProperties.Entry.ATime");
			entry.Size = _ctx.LongValue("GetDirectoryOrFileProperties.Entry.Size");
			entry.CTime = _ctx.StringValue("GetDirectoryOrFileProperties.Entry.CTime");
			entry.StorageType = _ctx.StringValue("GetDirectoryOrFileProperties.Entry.StorageType");
			entry.Name = _ctx.StringValue("GetDirectoryOrFileProperties.Entry.Name");
			entry.RetrieveTime = _ctx.StringValue("GetDirectoryOrFileProperties.Entry.RetrieveTime");
			entry.Inode = _ctx.StringValue("GetDirectoryOrFileProperties.Entry.Inode");
			entry.HasArchiveFile = _ctx.BooleanValue("GetDirectoryOrFileProperties.Entry.HasArchiveFile");
			getDirectoryOrFilePropertiesResponse.Entry = entry;
        
			return getDirectoryOrFilePropertiesResponse;
        }
    }
}
