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

namespace Aliyun.Acs.grace.Model.V20220606
{
	public class GetFileResponse : AcsResponse
	{

		private string type;

		private long? size;

		private long? creationTime;

		private string displayName;

		private string labels;

		private bool? shared;

		private string transferState;

		private string name;

		private string requestId;

		private GetFile_AnalyzeProgress analyzeProgress;

		private GetFile_TransferProgress transferProgress;

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public long? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
			}
		}

		public long? CreationTime
		{
			get
			{
				return creationTime;
			}
			set	
			{
				creationTime = value;
			}
		}

		public string DisplayName
		{
			get
			{
				return displayName;
			}
			set	
			{
				displayName = value;
			}
		}

		public string Labels
		{
			get
			{
				return labels;
			}
			set	
			{
				labels = value;
			}
		}

		public bool? Shared
		{
			get
			{
				return shared;
			}
			set	
			{
				shared = value;
			}
		}

		public string TransferState
		{
			get
			{
				return transferState;
			}
			set	
			{
				transferState = value;
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
			}
		}

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

		public GetFile_AnalyzeProgress AnalyzeProgress
		{
			get
			{
				return analyzeProgress;
			}
			set	
			{
				analyzeProgress = value;
			}
		}

		public GetFile_TransferProgress TransferProgress
		{
			get
			{
				return transferProgress;
			}
			set	
			{
				transferProgress = value;
			}
		}

		public class GetFile_AnalyzeProgress
		{

			private string message;

			private double? percent;

			private string state;

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public double? Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}
		}

		public class GetFile_TransferProgress
		{

			private long? totalSize;

			private long? transferredSize;

			public long? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			public long? TransferredSize
			{
				get
				{
					return transferredSize;
				}
				set	
				{
					transferredSize = value;
				}
			}
		}
	}
}
