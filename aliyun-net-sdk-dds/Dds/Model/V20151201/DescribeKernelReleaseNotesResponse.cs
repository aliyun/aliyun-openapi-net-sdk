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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeKernelReleaseNotesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeKernelReleaseNotes_ReleaseNote> releaseNotes;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeKernelReleaseNotes_ReleaseNote> ReleaseNotes
		{
			get
			{
				return releaseNotes;
			}
			set	
			{
				releaseNotes = value;
			}
		}

		public class DescribeKernelReleaseNotes_ReleaseNote
		{

			private string releaseNote;

			private string kernelVersion;

			public string ReleaseNote
			{
				get
				{
					return releaseNote;
				}
				set	
				{
					releaseNote = value;
				}
			}

			public string KernelVersion
			{
				get
				{
					return kernelVersion;
				}
				set	
				{
					kernelVersion = value;
				}
			}
		}
	}
}
