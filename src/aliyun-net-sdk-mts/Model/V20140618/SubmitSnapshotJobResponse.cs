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
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class SubmitSnapshotJobResponse : AcsResponse
	{
	    public SnapshotJob_ SnapshotJob { get; set; }

	    public class SnapshotJob_{
	        public string Id { get; set; }

	        public string UserData { get; set; }

	        public string PipelineId { get; set; }

	        public string State { get; set; }

	        public string Code { get; set; }

	        public string Count { get; set; }

	        public string Message { get; set; }

	        public string CreationTime { get; set; }

	        public Input_ Input { get; set; }

	        public SnapshotConfig_ SnapshotConfig { get; set; }

	        public MnsMessageResult_ MnsMessageResult { get; set; }

	        public class Input_{
	            public string Bucket { get; set; }

	            public string Location { get; set; }

	            public string Object { get; set; }
	        }

			public class SnapshotConfig_{
			    public string Time { get; set; }

			    public string Interval { get; set; }

			    public string Num { get; set; }

			    public string Width { get; set; }

			    public string Height { get; set; }

			    public string FrameType { get; set; }

			    public OutputFile_ OutputFile { get; set; }

			    public class OutputFile_{
			        public string Bucket { get; set; }

			        public string Location { get; set; }

			        public string Object { get; set; }
			    }
			}

			public class MnsMessageResult_
            {
			    public string MessageId { get; set; }

			    public string ErrorMessage { get; set; }

			    public string ErrorCode { get; set; }
			}
		}
	}
}