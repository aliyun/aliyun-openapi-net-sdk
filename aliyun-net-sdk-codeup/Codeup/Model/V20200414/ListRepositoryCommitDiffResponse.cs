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

namespace Aliyun.Acs.codeup.Model.V20200414
{
	public class ListRepositoryCommitDiffResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private List<ListRepositoryCommitDiff_ResultItem> result;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<ListRepositoryCommitDiff_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListRepositoryCommitDiff_ResultItem
		{

			private string aMode;

			private string bMode;

			private bool? deletedFile;

			private string diff;

			private bool? isBinary;

			private bool? isNewLfs;

			private bool? isOldLfs;

			private bool? newFile;

			private string newId;

			private string newPath;

			private string oldId;

			private string oldPath;

			private bool? renamedFile;

			public string AMode
			{
				get
				{
					return aMode;
				}
				set	
				{
					aMode = value;
				}
			}

			public string BMode
			{
				get
				{
					return bMode;
				}
				set	
				{
					bMode = value;
				}
			}

			public bool? DeletedFile
			{
				get
				{
					return deletedFile;
				}
				set	
				{
					deletedFile = value;
				}
			}

			public string Diff
			{
				get
				{
					return diff;
				}
				set	
				{
					diff = value;
				}
			}

			public bool? IsBinary
			{
				get
				{
					return isBinary;
				}
				set	
				{
					isBinary = value;
				}
			}

			public bool? IsNewLfs
			{
				get
				{
					return isNewLfs;
				}
				set	
				{
					isNewLfs = value;
				}
			}

			public bool? IsOldLfs
			{
				get
				{
					return isOldLfs;
				}
				set	
				{
					isOldLfs = value;
				}
			}

			public bool? NewFile
			{
				get
				{
					return newFile;
				}
				set	
				{
					newFile = value;
				}
			}

			public string NewId
			{
				get
				{
					return newId;
				}
				set	
				{
					newId = value;
				}
			}

			public string NewPath
			{
				get
				{
					return newPath;
				}
				set	
				{
					newPath = value;
				}
			}

			public string OldId
			{
				get
				{
					return oldId;
				}
				set	
				{
					oldId = value;
				}
			}

			public string OldPath
			{
				get
				{
					return oldPath;
				}
				set	
				{
					oldPath = value;
				}
			}

			public bool? RenamedFile
			{
				get
				{
					return renamedFile;
				}
				set	
				{
					renamedFile = value;
				}
			}
		}
	}
}
