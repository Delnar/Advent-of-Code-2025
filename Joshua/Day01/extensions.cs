namespace Day01;

public static class Extensions {
	extension (int value) {
		public int rotate(string command) {
			if (command.Length == 0)
				return value;

			var cmd  = command[0];
			var rest = command[1..];
			if (int.TryParse(rest, out var clicks) == false)
				return value;

			if (cmd == 'L') clicks = clicks * -1;
			return (value + clicks) % 100;
		}

		public (int retValue, int zeroPasses) rotate43(string command) {
			var retValue = value;

			if (command.Length == 0)
				return (retValue, 0);

			var cmd  = command[0];
			var rest = command[1..];
			if (int.TryParse(rest, out var clicks) == false)
				return (retValue, 0);
			var dir = (cmd == 'L') ? -1 : 1;
			var zeroPasses = 0;

			for(var x = 0; x < clicks; x++) {
				retValue += dir;
				retValue %= 100;
				if (retValue == 0) {
					zeroPasses += 1;
				}
			}
			
			return (retValue, zeroPasses);
		}


		public bool isZero() {
			return value == 0;
		}
	}
}
