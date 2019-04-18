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
        public static DescribeKernelReleaseNotesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeKernelReleaseNotesResponse describeKernelReleaseNotesResponse = new DescribeKernelReleaseNotesResponse();

			describeKernelReleaseNotesResponse.HttpResponse = context.HttpResponse;
			describeKernelReleaseNotesResponse.RequestId = context.StringValue("DescribeKernelReleaseNotes.RequestId");

			List<DescribeKernelReleaseNotesResponse.DescribeKernelReleaseNotes_ReleaseNote> describeKernelReleaseNotesResponse_releaseNotes = new List<DescribeKernelReleaseNotesResponse.DescribeKernelReleaseNotes_ReleaseNote>();
			for (int i = 0; i < context.Length("DescribeKernelReleaseNotes.ReleaseNotes.Length"); i++) {
				DescribeKernelReleaseNotesResponse.DescribeKernelReleaseNotes_ReleaseNote releaseNote = new DescribeKernelReleaseNotesResponse.DescribeKernelReleaseNotes_ReleaseNote();
				releaseNote.KernelVersion = context.StringValue("DescribeKernelReleaseNotes.ReleaseNotes["+ i +"].KernelVersion");
				releaseNote.ReleaseNote = context.StringValue("DescribeKernelReleaseNotes.ReleaseNotes["+ i +"].ReleaseNote");

				describeKernelReleaseNotesResponse_releaseNotes.Add(releaseNote);
			}
			describeKernelReleaseNotesResponse.ReleaseNotes = describeKernelReleaseNotesResponse_releaseNotes;
        
			return describeKernelReleaseNotesResponse;
        }
    }
}
