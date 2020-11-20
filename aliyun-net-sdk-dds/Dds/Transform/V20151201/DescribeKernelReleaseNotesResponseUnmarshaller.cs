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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeKernelReleaseNotesResponseUnmarshaller
    {
        public static DescribeKernelReleaseNotesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeKernelReleaseNotesResponse describeKernelReleaseNotesResponse = new DescribeKernelReleaseNotesResponse();

			describeKernelReleaseNotesResponse.HttpResponse = _ctx.HttpResponse;
			describeKernelReleaseNotesResponse.RequestId = _ctx.StringValue("DescribeKernelReleaseNotes.RequestId");

			List<DescribeKernelReleaseNotesResponse.DescribeKernelReleaseNotes_ReleaseNote> describeKernelReleaseNotesResponse_releaseNotes = new List<DescribeKernelReleaseNotesResponse.DescribeKernelReleaseNotes_ReleaseNote>();
			for (int i = 0; i < _ctx.Length("DescribeKernelReleaseNotes.ReleaseNotes.Length"); i++) {
				DescribeKernelReleaseNotesResponse.DescribeKernelReleaseNotes_ReleaseNote releaseNote = new DescribeKernelReleaseNotesResponse.DescribeKernelReleaseNotes_ReleaseNote();
				releaseNote.KernelVersion = _ctx.StringValue("DescribeKernelReleaseNotes.ReleaseNotes["+ i +"].KernelVersion");
				releaseNote.ReleaseNote = _ctx.StringValue("DescribeKernelReleaseNotes.ReleaseNotes["+ i +"].ReleaseNote");

				describeKernelReleaseNotesResponse_releaseNotes.Add(releaseNote);
			}
			describeKernelReleaseNotesResponse.ReleaseNotes = describeKernelReleaseNotesResponse_releaseNotes;
        
			return describeKernelReleaseNotesResponse;
        }
    }
}
